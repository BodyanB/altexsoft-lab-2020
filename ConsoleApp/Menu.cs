using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApp
{
    class Menu 
    {
        public static string Comand;

        public void ShowMenuScreen()
        {
            string autDate = "Author: B/B\t\t\t\t\t  Date:" + System.DateTime.Now;

            while (true)
            {

                if (Comand == "5") break;
                Console.WriteLine(autDate);
                Console.WriteLine("### MENU ###");
                Console.WriteLine("1. Read the text file  in the path and delete the symbol / word speced in the console in it.");
                Console.WriteLine("2. Reads a text file and print the number of words in the text, and print every 10th word separated by commas.");
                Console.WriteLine("3. Print the 3rd sentence in the text and the letters of the words must be in reverse order.");
                Console.WriteLine("4. Display the names of folders at the specified path in the console. Each folder must have an identifier.");
                Console.WriteLine("5. Exit.");
                Console.Write("\n" + "Enter the command 1-5: ");
                Comand = Console.ReadLine();
                switch (Comand)
                {
                    case "1":
                        Console.Clear();
                        Text rt = new Text();
                        rt.RText();
                        break;
                    case "2":
                        Console.Clear();
                        Word cw = new Word();
                        cw.CountWord();
                        break;
                    case "3":
                        Console.Clear();
                        ThirdSentence ts = new ThirdSentence();
                        ts.MoveTSentence();
                        break;
                    case "4":
                        Console.Clear();
                        FolderName fn = new FolderName();
                        fn.FName();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Exit");
                        return;

                }







            }
        }
    }
}
