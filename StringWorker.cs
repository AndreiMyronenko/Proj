using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class StringWorker
    {
        public static void CountLetters(string str)
        {
            int count = 0;
            if (str == string.Empty)
                Console.WriteLine("Вы не ввели строку!");
            if (str != string.Empty)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str.Substring(i, 1) != " "
                        && str.Substring(i, 1) != "!"
                        && str.Substring(i, 1) != "?"
                        && str.Substring(i, 1) != ":"
                        && str.Substring(i, 1) != ";"
                        && str.Substring(i, 1) != "."
                        && str.Substring(i, 1) != ",")
                        count++;
                }
                Console.WriteLine($"Количество букв: {count}");
            }
        }

        public static void CountWords(string str)
        {
            if (str == string.Empty)
                Console.WriteLine("Вы не ввели строку!");
            if (str != string.Empty)
            {
                string[] text;
                text = str.Split(' ');
                Console.WriteLine($"Количество слов: {text.Length}");
            }
        }

        public static void CountPunctuationMarks(string str)
        {
            int count = 0;
            if (str == string.Empty)
                Console.WriteLine("Вы не ввели строку!");
            if (str != string.Empty)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str.Substring(i, 1) == "!"
                        || str.Substring(i, 1) == "?"
                        || str.Substring(i, 1) == ":"
                        || str.Substring(i, 1) == ";"
                        || str.Substring(i, 1) == "."
                        || str.Substring(i, 1) == ",")
                        count++;
                }
            }
            Console.WriteLine($"Количество знаков препинания: {count}");
        }

        public static void CountSymbols(string str)
        {
            if (str == string.Empty)
                Console.WriteLine("Вы не ввели строку!");
            if (str != string.Empty)
                Console.WriteLine($"Количество символов: {str.Length}");
        }

        public static void CountSpaces(string str)
        {
            int count = 0;
            if (str == string.Empty)
                Console.WriteLine("Вы не ввели строку!");
            if (str != string.Empty)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str.Substring(i, 1) == " ")
                        count++;
                }
                Console.WriteLine($"Количество пробелов: {count}");
            }
        }
    }
}

