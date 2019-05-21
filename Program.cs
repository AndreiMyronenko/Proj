using forkRepo;
using System;
using Mawinka;
using System.Collections.Generic;
using Student;
using FindImagesTest;
using StringWorker;


class Program
{
    static int Factorial(int x)
    {
        if (x == 0)
            return 1;
        return x * Factorial(x - 1);
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine("Hello world");
        System.Console.WriteLine("Mish commit");
        System.Console.WriteLine(Factorial(5));

        Student Valera = new Student { Name = "Valera", Surname = "Mashina", Age = 67 };
        Student Bogdan = new Student { Name = "Bogdan", Surname = "GP", Age = 17 };
        Student Sasha = new Student { Name = "Sasha", Surname = "Brat", Age = 18 };
        Student Misha = new Student { Name = "Misha", Surname = "Mavashi", Age = 32 };
        Student Kolya = new Student { Name = "Kolya", Surname = "Lesnikov", Age = 17 };
        List<Student> students = new List<Student>();
        students.Add(Valera);
        students.Add(Bogdan);
        students.Add(Sasha);
        students.Add(Misha);
        students.Add(Kolya);
        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name} \t Surname:{student.Surname}\t Age:{student.Age}");
        }
        
        //Simirenko
        List<string> stringList = new List<string>() { "string1", "string2", "string3" };
        stringList.Add("string4");
        foreach (var i in stringList)
        {
            Console.WriteLine(i);
        }

        //Mironenko
    
        Console.WriteLine("Введите строку.");
        string str = Console.ReadLine();
        Thread.Sleep(1000);
        StringWorker.CountWords(str);
        Thread.Sleep(500);
        StringWorker.CountLetters(str);
        Thread.Sleep(500);
        StringWorker.CountPunctuationMarks(str);
        Thread.Sleep(500);
        StringWorker.CountSpaces(str);
        Thread.Sleep(500);
        StringWorker.CountSymbols(str);
            
        //end Mironenko
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


    private static async void DownloadImageAsync(string filePath)
    {
        await _downloader.DownloadAsync(new Uri(filePath));
        Console.WriteLine($"{_downloader.Filename}");
    }

    static async void Process()
    {
        IImagePathFinder finder = new ImagePathFinder("/Users/leonid/Downloads");
        await finder.FindAsync();
        foreach (var item in finder.Result)
        {
            Console.WriteLine(item);
        }
        List<Car> cars = Car.GetCars();
        foreach (Car item in cars)
        {
            Console.WriteLine($"{item.Title} ");
        }
    }
}
