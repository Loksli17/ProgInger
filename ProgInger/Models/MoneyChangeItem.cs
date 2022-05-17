using System;
using System.Collections.Generic;
using System.Text;

namespace ProgInger
{
    public class MoneyChangeItem
    {
        protected long     id;
        protected DateTime dateTime;
        protected long     money;
        protected string   goal;

        public MoneyChangeItem()
        {
            id       = 1;
            dateTime = new DateTime();
            money    = 322;
            goal     = "KFC";
        }

        public MoneyChangeItem(long id, DateTime dateTime, long money, string goal)
        {
            this.id       = id;
            this.dateTime = dateTime;
            this.money    = money;
            this.goal = goal;
        }

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
           
    }
}
