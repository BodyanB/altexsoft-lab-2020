using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace task1
{
    class Program
    {
        static public string Comand;
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\source\repos\altexsoft-lab-2020\ConsoleApp\ConsoleApp\bin\Debug\work.txt";
            while (true)
            {

                if (Comand == "5") break;

                Console.WriteLine("### MENU ###");
                Console.WriteLine("1. Считать по указанному в пути текстовый файл и удалить в нем указанный в консоли символ/слово.");
                Console.WriteLine("2. Считывает текстовый файл и вывести на экран количество слов в тексте, а также вывести каждое 10-е слово через запятую.");
                Console.WriteLine("3. Вывести 3-е предложение в тексте. При чем буквы слов должны быть в обратном порядке.");
                Console.WriteLine("4. Вывести имена папок по указанному пути в консоли. У каждой папки должен быть идентификатор, по которому пользователь сможет находить нужную папку и видеть все файлы.");
                Console.WriteLine("5. Exit.");
                Console.Write("\n" + "Введите номер команды : ");
                Comand = Console.ReadLine();
                switch (Comand)
                {
                    case "1":
                        {
                            ReadText(path);
                        }
                        break;
                    case "2":
                        {
                            CountWord(path);
                        }
                        break;
                    case "3":
                        {
                            ThirdSentence(path);
                        }
                        break;
                    case "4":
                        {
                            FolderName();
                        }
                        break;
                    case "5":
                        {
                            Console.WriteLine("Exit");
                        }
                        break;
                }

            }
        }
        static void ReadText(string path)
        {
            string Line;
            string pathNew = @"C:\Users\User\source\repos\altexsoft-lab-2020\ConsoleApp\ConsoleApp\bin\Debug\note.txt";
            using (StreamReader fs = File.OpenText(path))
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

        static void CountWord(string path)
        {
            string word;
            string readText = File.ReadAllText(path);
            string[] words = readText.Split(new char[] { ' ', '"', '.', '?', '!', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Количество слов:" + words.Length);

            List<string> resultWords = new List<string>();
            for (int i = 9; i < words.Length; i += 10)
            {
                word = words[i];
                resultWords.Add(word);
            }
            Console.WriteLine(String.Join(',', resultWords));
        }
        static void ThirdSentence(string path)
        {
            using (StreamReader str = File.OpenText(path))
            {
                int value = 0;
                char[] charArr = new char[] { ' ' };
                while (str.Peek() != -1)
                {
                    char simbol = (char)str.Read();
                    if (simbol == '.')
                    {
                        value += 1;
                        if (value == 2)
                        {
                            string Line = str.ReadLine();
                            string[] strArr = Line.Split(charArr);
                            char[] inputarray = Line.ToCharArray();
                            Array.Reverse(inputarray);
                            string output = new string(inputarray);
                            Console.WriteLine(output);
                        }
                    }
                }
            }
        }
        static void FolderName()
        {
            Console.WriteLine(@"Enter the path:");
            string path = Console.ReadLine();
            Dictionary<Int32, string> dirеctory = new Dictionary<int, string>();
            try
            {
                string[] dirs = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
                Console.WriteLine("The number of directories is {0}.", dirs.Length);
                for (int i = 0; i < dirs.Length; i++)
                {
                    dirеctory.Add(i + 1, dirs[i]);
                    Console.WriteLine($" {i + 1}.{dirs[i]}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            Console.WriteLine(@"Enter the folder numbers:");
            int select = Convert.ToInt32(Console.ReadLine());
            string targetDirectory = dirеctory[select];


            try
            {

                string[] fls = Directory.GetFiles(targetDirectory, "*");
                Console.WriteLine("The number of files is {0}.", fls.Length);
                foreach (string fl in fls)
                {
                    Console.WriteLine(fl);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }


        }
    }
}
