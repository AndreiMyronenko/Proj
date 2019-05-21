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

    private static IDownloader _downloader = new ImageDownloader();

    private static void DownloadImageDemonstation()
    {
        string path = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Shaqi_jrvej.jpg/1200px-Shaqi_jrvej.jpg";
        DownloadImageAsync(path);
    }

    private static async void DownloadImageAsync(string filePath)
    {
        await _downloader.DownloadAsync(new Uri(filePath));
        Console.WriteLine($"{_downloader.Filename}");
    }

    public static void Main(string[] args)
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

        System.Console.WriteLine("Hello world");
        System.Console.WriteLine("Mish commit");
        System.Console.WriteLine(Factorial(5));

        DownloadImageDemonstation();
        Console.ReadKey();

    }
}