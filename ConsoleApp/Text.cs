using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Text : Path
    {

        public void ReadText()
        {
            string textStream = ReadT();
            Console.Write("Enter the word or symbol to delete.");
            string word = Console.ReadLine();
            const string myStr = "note.txt";
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine(textStream);
            }
            else
               if (textStream.Contains(word))
                {
                    string textReplace = textStream.Replace(word, "");
                    Console.WriteLine(textReplace);
                    Console.Write("Enter the path to save file: ");
                    string writePath = (Console.ReadLine());
                    string writePathFile = writePath + myStr;
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePathFile, false, System.Text.Encoding.Default))
                        {
                            sw.WriteLine(textReplace);
                            sw.Close();
                        }
                        Console.WriteLine("Written to file: " + writePathFile);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            


                else
            {
                Console.WriteLine("There is no such word in the text.");
            }
        }
    }
}    
    

