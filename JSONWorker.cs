class  WorkWithJson<T> 
    {
        // json Save
        public void JsonSave(IEnumerable<T> collection)
        {

            string data = JsonConvert.SerializeObject(collection);
            File.WriteAllText("Data.json", data);
        }

        // json Load
        public IEnumerable<T> JsonLoad()
        {
            if (File.Exists("Data.json"))
            {
                return JsonConvert.DeserializeObject<IEnumerable<T>>(File.ReadAllText("Data.json"));

            }
            return null;
        }
    }