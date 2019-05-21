using Newtonsoft.Json;
using System;
using System.Collections.Generic;

static class Extention
{
    public static IEnumerable<T> DeserializeObjectCollection<T>(this string str)
    {
        List<T> result = null;

        try
        {
            result = JsonConvert.DeserializeObject<List<T>>(str);
        }
        catch (JsonReaderException jrex)
        {
            throw jrex;
        }

        return result;
    }
}

class Program
{
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

        try
        {
            string text = "kek";
            text.DeserializeObjectCollection<int>();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}