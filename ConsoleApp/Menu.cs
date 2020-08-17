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
        static public string Comand;

        public void ShowMenuScreen()
        {
            string autndate = "Author: B/B\t\t\t\t\t  Date:" + System.DateTime.Now;

            while (true)
            {

                if (Comand == "5") break;
                Console.WriteLine(autndate);
                Console.WriteLine("### MENU ###");
                Console.WriteLine("1. Считать по указанному в пути текстовый файл и удалить в нем указанный в консоли символ/слово.");
                Console.WriteLine("2. Считывает текстовый файл и вывести на экран количество слов в тексте, а также вывести каждое 10-е слово через запятую.");
                Console.WriteLine("3. Вывести 3-е предложение в тексте. При чем буквы слов должны быть в обратном порядке.");
                Console.WriteLine("4. Вывести имена папок по указанному пути в консоли. У каждой папки должен быть идентификатор, по которому пользователь сможет находить нужную папку и видеть все файлы.");
                Console.WriteLine("5. Exit.");
                Console.Write("\n" + "Введите команду: ");
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
                        cw.CWord();
                        break;
                    case "3":
                        Console.Clear();
                        ThirdSentence ts = new ThirdSentence();
                        ts.TSentence();
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
