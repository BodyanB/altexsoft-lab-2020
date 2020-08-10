using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class ReadText : Menu
    {
        
        public void RText()
        {
            Console.WriteLine(FILEPATHS);
            string Line;
            string pathNew = @"C:\Users\User\source\repos\altexsoft-lab-2020\ConsoleApp\ConsoleApp\bin\Debug\note.txt";
            //string path = @"C:\Users\User\source\repos\altexsoft-lab-2020\ConsoleApp\ConsoleApp\bin\Debug\work.txt";
            using (StreamReader fs = File.OpenText(m_filepaths))
            {
                while (fs.Peek() != -1)
                {

                    Line = fs.ReadLine();

                    var charsToRemove = new string[] { "@", ",", ".", ";", "'", "!", "?", "(", ")" };

                    foreach (var c in charsToRemove)
                    {
                        Line = Line.Replace(c, string.Empty);
                    }
                    Console.WriteLine(Line);
                    File.AppendAllText(pathNew, Line);
                }
            }
            string readText = File.ReadAllText(pathNew);
            string pattern = @"\?\^\`\{\}\|";
            int result = String.Compare(readText, pattern);
            if (Regex.Matches(readText, pattern).Count == 0)
            {
                Console.WriteLine("Такой подстроки нет!");
            }
            else
            {
                Console.WriteLine("Такая подстрока есть!");
            }
        }
        
    }
}
