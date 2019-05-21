using System;


public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
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
    }
}