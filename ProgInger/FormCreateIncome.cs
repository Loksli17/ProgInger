using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgInger
{
    public partial class FormCreateIncome : Form
    {
        public FormCreateIncome()
        {
            InitializeComponent();
        }

        private JsonFileAdapter incomeFileAdapter = new JsonFileAdapter("income.json");


        private void createIncomeBtn_Click(object sender, EventArgs e)
        {
            MoneyChangeItem item = new MoneyChangeItem();

            item.Goal  = goalView.Text.ToString();
            item.Money = long.Parse(moneyView.Value.ToString());

            DateTime dateTime = new DateTime();
            dateTime = dateView.Value + new TimeSpan(
                timeView.Value.Hour, 
                timeView.Value.Minute, 
                timeView.Value.Second
            );

            item.DateTime = dateTime;

            incomeFileAdapter.save(item);
        }
    }
}
