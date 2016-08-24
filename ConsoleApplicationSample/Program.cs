using System;
using System.Configuration;
using LibSettings = ClassLibrarySample.Properties.Settings;
using AppSettings = ConsoleApplicationSample.Properties.Settings;

namespace ConsoleApplicationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
            Console.WriteLine("LibS1: {0}", LibSettings.Default.LibS1);
            Console.WriteLine("AppS1: {0}", AppSettings.Default.AppS1);
            
            Console.ReadLine();
        }
    }
}
