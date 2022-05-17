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
                Debug.WriteLine(json.ToString());
                Debug.WriteLine(json.data.Count);
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


        public void saveEntity(MoneyChangeItem item)
        {
            JsonStructure json = getDataFromFile();
            json.data.Add(item);
            writeDataInFile(json);
        }

        
        public List<MoneyChangeItem> getAll(int year, int month)
        {
            JsonStructure         json   = getDataFromFile();
            List<MoneyChangeItem> result = new List<MoneyChangeItem>();

            new List<MoneyChangeItem>(json.data).ForEach((MoneyChangeItem item) =>
            {
                Debug.WriteLine("AZAZA" + item.getMonth() + "" + (month + 1));
                if (item.getYear() == year && item.getMonth() == month + 1) result.Add(item);
            });
            
            return result;
        }


        public MoneyChangeItem getLast()
        {
            JsonStructure json = getDataFromFile();
            return json.data[json.data.Count - 1];
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
    }
}
