using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgInger
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();

            if (type == "income")
            {
                Debug.WriteLine("id " + id);
                moneyViewEdit.Maximum = 1000000;
                moneyViewEdit.Minimum = 1;
                label5.Text = "Изменение дохода";
                item = incomeFileAdapter.getById(id);
            }
            else
            {
                Debug.WriteLine("id " + id);
                moneyViewEdit.Maximum = -1;
                moneyViewEdit.Minimum = -1000000;
                label5.Text = "Изменение убытка";
                item = lesionFileAdapter.getById(id);
            }

            goalViewEdit.Text   = item.Goal;
            moneyViewEdit.Value = item.Money;
        }

        private JsonFileAdapter incomeFileAdapter = new JsonFileAdapter("income.json");
        private JsonFileAdapter lesionFileAdapter = new JsonFileAdapter("lesion.json");

        public static string type = "income";
        public static int id;
        public MoneyChangeItem item;


        private void editBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
