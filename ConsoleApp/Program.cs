using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ConsoleApp;

namespace task1
{
    class Program
    {

        static void Main(string[] args)
        {

            Menu menu = new Menu();
            menu.ShowMenuScreen();


            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();

        }
    }
}
