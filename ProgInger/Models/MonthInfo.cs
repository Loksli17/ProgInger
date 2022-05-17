using System;
using System.Collections.Generic;
using System.Text;


namespace ProgInger
{
    class MonthInfo
    {
        private string month;
        private long   money;

        public long Money
        {
            get => money;
            set => money = value;
        }

        public string Month
        {
            get => month;
            set => month = value;
        }

        public MonthInfo(string month, long money) {
            this.money = money;
            this.month = month;
        }
    }
}
