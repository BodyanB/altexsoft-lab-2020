using System;
using System.IO;

namespace ConsoleApp
{
    internal class ReadFile
    {
        public static string ReadT()
        {
            Console.Write("Enter the path:");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                string textStream = File.ReadAllText(path); 
                return textStream;
            }
            else
            {
                Console.WriteLine("File does not exist.");
                Console.ReadKey();
                return null;
            }
        }
    }
}
