using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp
{
    class Word : Text
    {
        public void CWord()
        {
            
            string word;
            string textStream = ReadT();
            string[] words = textStream.Split(new char[] { ' ', '"', '.', '?', '!', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Количество слов:" + words.Length);

            List<string> resultWords = new List<string>();
            for (int i = 9; i < words.Length; i += 10)
            {
                word = words[i];
                resultWords.Add(word);
            }
            Console.WriteLine(String.Join(',', resultWords));
            
        }
    }
}
