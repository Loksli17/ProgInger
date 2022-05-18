using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Json;


class JsonStructure
{
    public IList<ProgInger.MoneyChangeItem> data { get; set; }
}


namespace ProgInger
{
    class JsonFileAdapter
    {

        private string fileName = "";
        private string path     = "../../../json/";


        public JsonFileAdapter(string fileName)
        {
            this.fileName = fileName;
        }


        private JsonStructure getDataFromFile()
        {

            string fileContent = "";

            try
            {
                fileContent = System.IO.File.ReadAllText(path + fileName);
            }
            catch (System.IO.FileNotFoundException e)
            {
                Debug.WriteLine(e.ToString());
            }

            JsonStructure json = new JsonStructure();

            try
            {
                json = JsonSerializer.Deserialize<JsonStructure>(fileContent);
            }
            catch (JsonException e)
            {
                Debug.WriteLine(e.ToString());
            }
            catch (NotSupportedException e)
            {
                Debug.WriteLine(e.ToString());
            }

            return json;
        }


        private void writeDataInFile(JsonStructure json)
        {
            string jsonString = JsonSerializer.Serialize(json);

            try
            {
                System.IO.File.WriteAllText(path + fileName, jsonString);
            }
            catch (System.IO.FileNotFoundException e)
            {
                Debug.WriteLine(e.ToString());
            }
        }


        public void save(MoneyChangeItem item)
        {
            JsonStructure json = getDataFromFile();
            json.data.Add(item);
            writeDataInFile(json);
        }


        public void removeById(long id)
        {
            JsonStructure json = getDataFromFile();

            new List<MoneyChangeItem>(json.data).ForEach((MoneyChangeItem item) =>
            {
                if (item.Id == id) json.data.Remove(item);
            });

            writeDataInFile(json);
        }

        
        public List<MoneyChangeItem> getAll(int year, int month)
        {
            JsonStructure         json   = getDataFromFile();
            List<MoneyChangeItem> result = new List<MoneyChangeItem>();

            new List<MoneyChangeItem>(json.data).ForEach((MoneyChangeItem item) =>
            { 
                if (item.getYear() == year && item.getMonth() == month + 1) result.Add(item);
            });
            
            return result;
        }


        public MoneyChangeItem getLast()
        {
            JsonStructure json = getDataFromFile();
            return json.data[json.data.Count - 1];
        }


        public MoneyChangeItem getById(long id)
        {
            JsonStructure   json   = getDataFromFile();
            MoneyChangeItem result = null;

            new List<MoneyChangeItem>(json.data).ForEach((MoneyChangeItem item) =>
            {
                if (item.Id == id) result = item;
            });

            return result != null ? result : null;
        }


        public int getMinYear()
        {
            JsonStructure json = getDataFromFile();

            int min = int.MaxValue;

            new List<MoneyChangeItem>(json.data).ForEach((MoneyChangeItem item) =>
            {
                min = item.getYear() < min ? item.getYear() : min;
            });

            return min;
        }

        
        public List<MonthInfo> getMonthsInfo(int year)
        {

            List<MonthInfo> months = new List<MonthInfo>();

            months.Add(new MonthInfo("Январь", 0));
            months.Add(new MonthInfo("Февраль", 0));
            months.Add(new MonthInfo("Март", 0));
            months.Add(new MonthInfo("Апрель", 0));
            months.Add(new MonthInfo("Май", 0));
            months.Add(new MonthInfo("Июнь", 0));
            months.Add(new MonthInfo("Июль", 0));
            months.Add(new MonthInfo("Август", 0));
            months.Add(new MonthInfo("Сентябрь", 0));
            months.Add(new MonthInfo("Октябрь", 0));
            months.Add(new MonthInfo("Ноябрь", 0));
            months.Add(new MonthInfo("Декабрь", 0));

            JsonStructure json = getDataFromFile();

            new List<MoneyChangeItem>(json.data).ForEach((MoneyChangeItem item) =>
            {
                if(year == item.getYear()) months[item.getMonth() - 1].Money += item.Money;
            });

            return months;
        }
    }
}
