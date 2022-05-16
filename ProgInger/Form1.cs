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

        private List<Income> incomeItems = new List<Income>();

        public Form1()
        {
            InitializeComponent();

            initColumns();

            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());
            incomeItems.Add(new Income());

            pushRowsInGridView(incomeItems);
        }


        private void initColumns()
        {
            string[][] columns = {
                new string[] { "id",     "Id" },
                new string[] { "date",   "Date" },
                new string[] { "goal",   "Goal" },
                new string[] { "money+", "Money" },
            };

            for (int i = 0; i < columns.Length; i++)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                col.Name = columns[i][0];
                col.HeaderText = columns[i][1];
                col.CellTemplate = new DataGridViewTextBoxCell();
                incomesView.Columns.Insert(i, col);
            }
        }

        
        private void pushRowsInGridView(List<Income> items)
        {

            items.ForEach((Income item) => {
                incomesView.Rows.Add(item.Id, item.DateTime, item.Goal, item.Money);
            });
        }
    }
}
