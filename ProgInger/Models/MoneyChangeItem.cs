using System;
using System.Collections.Generic;
using System.Text;

namespace ProgInger
{
    public abstract class MoneyChangeItem
    {
        private long     id;
        private DateTime dateTime;
        private long     money;
        private string   goal;

        public long Id
        {
            get => id;
            set => id = value;
        }

        public DateTime DateTime
        {
            get => dateTime;
            set => dateTime = value;
        }

        public long Money
        {
            get => money;
            set => money = value;
        }

        public string Goal
        {
            get => goal;
            set => goal = value;
        }

        public MoneyChangeItem()
        {
            id       = 1;
            dateTime = new DateTime();
            money    = 322;
            goal     = "KFC";
        }
           
    }
}
