using System;


class Program
{

   
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

    static int Factorial(int x)
    {
        if (x == 0)
            return 1;
        return x * Factorial(x - 1);
    }
    public static void Main(string [] args)
    {
        System.Console.WriteLine("Hello world");
        System.Console.WriteLine("Mish commit"); 
        System.Console.WriteLine(Factorial(5));
    }
}