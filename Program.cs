using System;
using System.Collections.Generic;


public interface IStudent
{
    string Name { get; set; }
    string Surname { get; set; }
    int Age { get; set; }
}


public class Student : IStudent
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
    public static void Main(string[] args)
    {
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

    }
}