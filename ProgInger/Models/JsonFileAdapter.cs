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

        public void saveEntity(MoneyChangeItem item)
        {
            string fileContent = "";

            try
            {
                fileContent = System.IO.File.ReadAllText("../../../income.json");
            } catch (System.IO.FileNotFoundException e)
            {
                Debug.WriteLine(e.ToString());
            }

            Debug.WriteLine(fileContent);

            JsonStructure json;

            try
            {
                json = JsonSerializer.Deserialize<JsonStructure>(fileContent);
                Debug.WriteLine(json.ToString());
                Debug.WriteLine(json.data.Count);
            }
            catch (JsonException e)
            {
                Debug.WriteLine(e.ToString());
            } catch(NotSupportedException e)
            {
                Debug.WriteLine(e.ToString());
            }

            //json.data.Add(item);
            //string jsonString = JsonSerializer.Serialize(json);

            
            //Debug.WriteLine(JsonSerializer.Serialize(item));

            //try
            //{
            //    System.IO.File.WriteAllText("../../../income.json", jsonString);
            //}
            //catch (System.IO.FileNotFoundException e)
            //{
            //    Debug.WriteLine(e.ToString());
            //}
        }
    }
}
