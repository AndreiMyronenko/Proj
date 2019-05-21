using System;


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
    }
}