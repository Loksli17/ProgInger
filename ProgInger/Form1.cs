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


        public Form1()
        {
            InitializeComponent();
            initIncomeTableAdapter();
            initLesionTableAdapter();
        }


        private void initIncomeTableAdapter()
        {
            incomeTable = new TableViewAdapter(incomesView);

            string[][] columns = {
                new string[] { "id",    "Id" },
                new string[] { "date",  "Date" },
                new string[] { "goal",  "Goal" },
                new string[] { "money", "Money+" },
            };

            incomeTable.initColumns(columns);

            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());

            incomeTable.pushRowsInGridView(incomeItems);
        }


        private void initLesionTableAdapter()
        {
            lesionTable = new TableViewAdapter(lecionsView);

            string[][] columns = {
                new string[] { "id",    "Id" },
                new string[] { "date",  "Date" },
                new string[] { "goal",  "Goal" },
                new string[] { "money", "Money-" },
            };

            lesionTable.initColumns(columns);

            lesionItems.Add(new Lesion());
            lesionItems.Add(new Lesion());
            lesionItems.Add(new Lesion());
            lesionItems.Add(new Lesion());
            lesionItems.Add(new Lesion());
            lesionItems.Add(new Lesion());
            lesionItems.Add(new Lesion());
            lesionItems.Add(new Lesion());

            lesionTable.pushRowsInGridView(lesionItems);
        }
    }
}
