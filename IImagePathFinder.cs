using System;

namespace FindImagesTest
{
    class Program
    {
        static void Main(string[] args)
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
}
