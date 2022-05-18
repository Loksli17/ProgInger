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

            initDropDownMonths();
            initDropDownYears();

            incomeItems = incomeFileAdapter.getAll(int.Parse(yearDropView.SelectedItem.ToString()), monthDropView.SelectedIndex);
            lesionItems = lesionFileAdapter.getAll(int.Parse(yearDropView.SelectedItem.ToString()), monthDropView.SelectedIndex);

            initIncomeTableAdapter();
            initLesionTableAdapter();

            countMonthResult();

            monthViewBind();
        }


        private void initDropDownMonths()
        {
            var bindingSourceMonth = new BindingSource();
            bindingSourceMonth.DataSource = months;
            monthDropView.DataSource = bindingSourceMonth;

            DateTime date = DateTime.Today;

            for(int i = 0; i < months.Count; i++)
            {
                if(i + 1 == date.Month) monthDropView.SelectedIndex = i;
            }
        }

        private void monthViewBind()
        {
            if (yearDropView.SelectedItem == null) return;

            monthView.Items.Clear();

            List<MonthInfo> monthsInfoIncome = incomeFileAdapter.getMonthsInfo(int.Parse(yearDropView.SelectedItem.ToString()));
            List<MonthInfo> monthsInfoLesion = lesionFileAdapter.getMonthsInfo(int.Parse(yearDropView.SelectedItem.ToString()));

            for (int i = 0; i < monthsInfoIncome.Count; i++)
            {
                ListViewItem listItem = new ListViewItem(monthsInfoIncome[i].Month);
                listItem.SubItems.Add((monthsInfoIncome[i].Money + monthsInfoLesion[i].Money).ToString());
                monthView.Items.Add(listItem);
            }
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
            yearDropView.SelectedIndex = years.Count - 1;
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

            incomeTable.initColumns(columns, new int[]{30, 70, 90, 55});

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

            lesionTable.initColumns(columns, new int[] { 30, 70, 90, 55 });

            lesionTable.pushRowsInGridView(lesionItems);
        }


        private void filterData()
        {
            if (yearDropView.SelectedItem != null) incomeItems = incomeFileAdapter.getAll(int.Parse(yearDropView.SelectedItem.ToString()), monthDropView.SelectedIndex);
            if (yearDropView.SelectedItem != null) lesionItems = lesionFileAdapter.getAll(int.Parse(yearDropView.SelectedItem.ToString()), monthDropView.SelectedIndex);

            if (incomeTable != null) incomeTable.setRows(incomeItems);
            if (lesionTable != null) lesionTable.setRows(lesionItems);

            if (incomeTable != null && lesionTable != null) countMonthResult();

            monthViewBind();
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
            FormCreate.type = "income";
            FormCreate form = new FormCreate();
            form.ShowDialog(this);
            form.Dispose();

            filterData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCreate.type = "lesion";
            FormCreate form = new FormCreate();
            form.ShowDialog(this);
            form.Dispose();

            filterData();
        }


        private void yearDropView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(yearDropView.SelectedItem != null) filterData();

            currentYearView.Text = yearDropView.SelectedItem.ToString();
        }

        private void monthDropView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthDropView.SelectedItem != null) filterData();
        }


        private void incomesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowInd = e.RowIndex;
            int eventIndex = int.Parse(incomesView.Rows[rowInd].Cells[0].Value.ToString());

            if (e.ColumnIndex == incomesView.Columns.Count - 1)
            {
                //edit
                FormEdit.type = "income";
                FormEdit.id   = eventIndex;
                FormEdit form = new FormEdit();
    
                form.ShowDialog(this);
                form.Dispose();

                filterData();
            }
            else if(e.ColumnIndex == incomesView.Columns.Count - 2)
            {
                //delete
                incomeFileAdapter.removeById(eventIndex);
            }

            filterData();
        }


        private void lecionsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowInd = e.RowIndex;
            int eventIndex = int.Parse(lecionsView.Rows[rowInd].Cells[0].Value.ToString());

            if (e.ColumnIndex == lecionsView.Columns.Count - 1)
            {
                //edit
                FormEdit.type = "lesion";
                FormEdit.id   = eventIndex;
                FormEdit form = new FormEdit();

                form.ShowDialog(this);
                form.Dispose();

                filterData();
            }
            else if (e.ColumnIndex == lecionsView.Columns.Count - 2)
            {
                //delete
                lesionFileAdapter.removeById(eventIndex);
            }

            filterData();
        }
    }
}
