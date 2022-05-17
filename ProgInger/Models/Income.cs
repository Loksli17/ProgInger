using System;
using System.Collections.Generic;
using System.Text;


namespace ProgInger
{
    public class Income : MoneyChangeItem
    {

        private static long countId = new JsonFileAdapter("income.json").getLast().Id;

        public Income() : base()
        {
            countId++;
            id = countId;
        }
    }
}
