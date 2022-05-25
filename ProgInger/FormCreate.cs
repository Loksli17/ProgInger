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
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();

            if (type == "income")
            {
                moneyView.Maximum = 1000000;
                moneyView.Minimum = 1;
                label5.Text = "Добавление дохода";
            }
            else
            {
                moneyView.Maximum = -1;
                moneyView.Minimum = -1000000;
                label5.Text = "Добавление убытка";
            }
        }

        private JsonFileAdapter incomeFileAdapter = new JsonFileAdapter("income.json");
        private JsonFileAdapter lesionFileAdapter = new JsonFileAdapter("lesion.json");

        public static string type = "income";


        private void createIncomeBtn_Click(object sender, EventArgs e)
        {

            MoneyChangeItem item;

            if (type == "income") item = new Income();
            else                  item = new Lesion();

            item.Goal  = goalView.Text.ToString();
            item.Money = long.Parse(moneyView.Value.ToString());

            DateTime dateTime;
            dateTime = dateView.Value + new TimeSpan(
                timeView.Value.Hour, 
                timeView.Value.Minute, 
                timeView.Value.Second
            );

            item.DateTime = dateTime;

            if (type == "income")
            {
                incomeFileAdapter.saveItem(item);
                MessageBox.Show($"Доход был успешно добавлен");
            }
            else
            {
                lesionFileAdapter.saveItem(item);
                MessageBox.Show($"Убыток был успешно добавлен");
            }                
        }
    }
}
