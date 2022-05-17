using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        public Form1()
        {
            InitializeComponent();
           

            //incomeFileAdapter.saveEntity(new Income());
            //lesionFileAdapter.saveEntity(new Lesion());

            incomeItems = incomeFileAdapter.getAll();
            lesionItems = lesionFileAdapter.getAll();

            initIncomeTableAdapter();
            initLesionTableAdapter();
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

            //incomeItems.Add(new Income());
            //incomeItems.Add(new Income());
            //incomeItems.Add(new Income());
            //incomeItems.Add(new Income());
            //incomeItems.Add(new Income());
            //incomeItems.Add(new Income());
            //incomeItems.Add(new Income());
            //incomeItems.Add(new Income());

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

            //lesionItems.Add(new Lesion());
            //lesionItems.Add(new Lesion());
            //lesionItems.Add(new Lesion());
            //lesionItems.Add(new Lesion());
            //lesionItems.Add(new Lesion());
            //lesionItems.Add(new Lesion());
            //lesionItems.Add(new Lesion());
            //lesionItems.Add(new Lesion());

            lesionTable.pushRowsInGridView(lesionItems);
        }
    }
}
