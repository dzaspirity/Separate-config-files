using System;
using System.Configuration;
using ClassLibrarySample.Properties;

namespace ConsoleApplicationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
            Console.WriteLine(Settings.Default.LibS1);
            Console.ReadLine();
        }
    }
}
