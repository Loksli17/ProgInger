using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProgInger
{
    public partial class Form1 : Form
    {

        private List<MoneyChangeItem> incomeItems = new List<MoneyChangeItem>();
        private List<MoneyChangeItem> lesionItems = new List<MoneyChangeItem>();

        private TableViewAdapter incomeTable;
        private TableViewAdapter lesionTable;

        private JsonFileAdapter incomeFileAdapter = new JsonFileAdapter("income.json");
        private JsonFileAdapter lesionFileAdapter = new JsonFileAdapter("lesion.json");

        private List<string> years  = new List<string>();
        private List<string> months = new List<string>
        {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь",
        };


        public Form1()
        {
            InitializeComponent();
           
            //incomeFileAdapter.saveEntity(new Income());
            //lesionFileAdapter.saveEntity(new Lesion());

            initDropDownMonths();
            initDropDownYears();

            incomeItems = incomeFileAdapter.getAll(int.Parse(yearDropView.SelectedItem.ToString()), monthDropView.SelectedIndex);
            lesionItems = lesionFileAdapter.getAll(int.Parse(yearDropView.SelectedItem.ToString()), monthDropView.SelectedIndex);

            initIncomeTableAdapter();
            initLesionTableAdapter();

            countMonthResult();

            Debug.WriteLine(incomeFileAdapter.getMonthsInfo(int.Parse(yearDropView.SelectedItem.ToString()))[0].Money);
            Debug.WriteLine(incomeFileAdapter.getMonthsInfo(int.Parse(yearDropView.SelectedItem.ToString()))[0].Month);
        }


        private void initDropDownMonths()
        {
            var bindingSourceMonth = new BindingSource();
            bindingSourceMonth.DataSource = months;
            monthDropView.DataSource = bindingSourceMonth;
        }


        private void initDropDownYears()
        {
            DateTime dateTime = DateTime.Today;

            string firstYear; 
            
            if(incomeFileAdapter.getMinYear() < lesionFileAdapter.getMinYear())
            {
                firstYear = incomeFileAdapter.getMinYear().ToString();
            } else {
                firstYear = lesionFileAdapter.getMinYear().ToString();
            }

            years.Add(firstYear);

            for (int i = 0; i < dateTime.Year - int.Parse(years[0]); i++)
            {
                years.Add((int.Parse(years[0]) + i + 1).ToString());
            }

            var bindingSourceYears = new BindingSource();
            bindingSourceYears.DataSource = years;
            yearDropView.DataSource = bindingSourceYears;
        }

 
        private void initIncomeTableAdapter()
        {
            incomeTable = new TableViewAdapter(incomesView);

            string[][] columns = {
                new string[] { "id",    "Id" },
                new string[] { "date",  "Дата" },
                new string[] { "goal",  "Источник поступления" },
                new string[] { "money", "Поступление" },
            };

            incomeTable.initColumns(columns);

            incomeTable.pushRowsInGridView(incomeItems);
        }


        private void initLesionTableAdapter()
        {
            lesionTable = new TableViewAdapter(lecionsView);

            string[][] columns = {
                new string[] { "id",    "Id" },
                new string[] { "date",  "Дата" },
                new string[] { "goal",  "Предмет траты" },
                new string[] { "money", "Убыток" },
            };

            lesionTable.initColumns(columns);

            lesionTable.pushRowsInGridView(lesionItems);
        }


        private void filterData()
        {
            if (yearDropView.SelectedItem != null) incomeItems = incomeFileAdapter.getAll(int.Parse(yearDropView.SelectedItem.ToString()), monthDropView.SelectedIndex);
            if (yearDropView.SelectedItem != null) lesionItems = lesionFileAdapter.getAll(int.Parse(yearDropView.SelectedItem.ToString()), monthDropView.SelectedIndex);

            if (incomeTable != null) incomeTable.setRows(incomeItems);
            if (lesionTable != null) lesionTable.setRows(lesionItems);

            if (incomeTable != null && lesionTable != null) countMonthResult();
        }

        
        private void countMonthResult()
        {

            long result = 0;

            incomeItems.ForEach((MoneyChangeItem item) =>
            {
                result += item.Money;
            });

            lesionItems.ForEach((MoneyChangeItem item) =>
            {
                result += item.Money;
            });

            monthResultView.Text = result.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormCreateIncome form = new FormCreateIncome();
            form.ShowDialog(this);
            form.Dispose();
        }


        private void yearDropView_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void monthDropView_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData();
        }
    }
}
