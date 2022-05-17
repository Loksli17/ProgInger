using System;
using System.Collections.Generic;
using System.Text;


namespace ProgInger
{
    class Lesion : MoneyChangeItem
    {
        private static long countId = new JsonFileAdapter("lesion.json").getLast().Id;

        public Lesion() : base()
        {
            countId++;
            id = countId;
            money *= -1;
        }
    }
}
