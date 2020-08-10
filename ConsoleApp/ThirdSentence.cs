using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp
{
    class ThirdSentence
    {
        public void TSentence()           
        {
            Console.WriteLine("3");
            /*
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
            }*/
        } 
    }
}
