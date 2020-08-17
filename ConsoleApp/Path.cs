﻿using System;
using System.IO;

namespace ConsoleApp
{
    internal class ReadFile
    {
        public static string ReadT()
        {
            Console.Write("Введите путь к файлу ");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                string textStream = File.ReadAllText(path); 
                return textStream;
            }
            else
            {
                Console.WriteLine("Указаного файл нет");
                Console.ReadKey();
                return null;
            }
        }
    }
}