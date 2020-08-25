using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApp
{
    class Word : Path
    {
        public void CountWord()
        {
            
            string word;
            string textStream = ReadT();
            Regex regex = new Regex(@"[^\w'\s]+", RegexOptions.Compiled);
            string replaceText = regex.Replace(textStream, "").Trim();
            Regex regex1 = new Regex(@"\s+", RegexOptions.Compiled);
            string[] words = regex1.Split(replaceText.Trim()); 

            Console.WriteLine("Key word:" + words.Length);

            List<string> resultWords = new List<string>();
            for (int i = 9; i < words.Length; i += 10)
            {
                word = words[i];
                resultWords.Add(word);
            }
            Console.WriteLine(string.Join(',', resultWords));
            
        }
    }
}
