using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleApp
{
    class ThirdSentence : Text
    {
        public void MoveTSentence()           
        {
            string textStream = ReadT();

            string[] sentences = textStream.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            if (sentences.Length >= 3)
            {
                string senrence = sentences[2];
                string[] words = senrence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string word;
                List<string> reverseWords = new List<string>();
                for (int i = 0; i < words.Length; i++)
                {
                    word = words[i];
                    reverseWords.Add(new string(word.ToCharArray().Reverse().ToArray()));
                }

                Console.WriteLine(string.Join(' ', reverseWords));
            }
            else
            {
                Console.WriteLine("Sentence does not exist.");
            }
        }
    }
}
