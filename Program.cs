using System;
using FindImagesTest;

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
        Process();
        Console.ReadKey();
    }

    static async void Process()
    {
        IImagePathFinder finder = new ImagePathFinder("/Users/leonid/Downloads");
        await finder.FindAsync();
        foreach (var item in finder.Result)
        {
            Console.WriteLine(item);
        }
    }
}