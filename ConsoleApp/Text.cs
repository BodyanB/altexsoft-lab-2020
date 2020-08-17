using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Text : ReadFile
    {

        public void RText()
        {
            string textStream = ReadT();
            Console.Write("Введите слово или символ для удаления. ");
            string word = Console.ReadLine();
            if (String.IsNullOrEmpty(word))
            {
                Console.WriteLine(textStream);
            }
            else
               if (textStream.Contains(word))
                {
                    string textReplace = textStream.Replace(word, "");
                    Console.WriteLine(textReplace);
                    Console.Write("Введите путь для сохранения файла: ");
                    string writePath = (Console.ReadLine());
                    string writePathFile = writePath + "note.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePathFile, false, System.Text.Encoding.Default))
                        {
                            sw.WriteLine(textReplace);
                            sw.Close();
                        }
                        Console.WriteLine("Запись выполнена в файл: " + writePathFile);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            


                else
            {
                Console.WriteLine("В тексте нет такого слова");
            }
        }
    }
}    
    

