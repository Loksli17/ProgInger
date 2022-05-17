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

            Debug.WriteLine(fileContent);

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

        
        public List<MoneyChangeItem> getAll()
        {
            JsonStructure json = getDataFromFile();
            return new List<MoneyChangeItem>(json.data);
        }


        public MoneyChangeItem getLast()
        {
            JsonStructure json = getDataFromFile();
            return json.data[json.data.Count - 1];
        }
    }
}
