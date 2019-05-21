using System;


class Program
{
    static int Factorial(int x)
    {
        if (x == 0)
            return 1;
        return x * Factorial(x - 1);
    }

    private static dynamic FactorialPy(string pyFile, string arg)
    {
        int x = int.Parse(arg);

        ScriptEngine engine = Python.CreateEngine();
        ScriptScope scope = engine.CreateScope();

        engine.ExecuteFile(pyFile, scope);
        dynamic function = scope.GetVariable("factorial");
        dynamic result = function(x);
        return result;
    }
    public static void Main(string [] args)
    {
        System.Console.WriteLine("Hello world");
        System.Console.WriteLine(Factorial(5));
        Console.WriteLine(FactorialPy("1.py", "5"));
    }
}