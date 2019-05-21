using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{

    class Program
    {
        static int Factorial(int x)
        {
            if (x == 0)
                return 1;
            return x * Factorial(x - 1);
        }

        class ListOfStrings : IStringList
        {
            List<string> stringList = new List<string>();

            public void Add(string line)
            {
                stringList.Add(line);
            }
            public void Delete(string line)
            {
                stringList.Remove(line);
            }

            public IEnumerator<string> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public void Print()
            {
                foreach (var i in stringList)
                {
                    Console.WriteLine(i);
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world");
            System.Console.WriteLine("Mish commit");
            System.Console.WriteLine(Factorial(5));

            List<string> stringList = new List<string>() { "string1", "string2", "string3" };
            stringList.Add("string4");
            foreach (var i in stringList)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
