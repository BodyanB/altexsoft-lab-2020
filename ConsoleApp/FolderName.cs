﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    class FolderName
    {
        public void ChooseFileDir()
        {
            Console.WriteLine(@"Enter the path:");
            string path = Console.ReadLine();
            Dictionary<int, string> dirеctory = new Dictionary<int, string>();
            try
            {
                string[] dirs = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
                Array.Sort(dirs);
                Console.WriteLine("The number of directories is {0}.", dirs.Length);
                for (int i = 0; i < dirs.Length; i++)
                {
                    dirеctory.Add(i + 1, dirs[i]);
                    Console.WriteLine($" {i + 1}.{dirs[i]}");
                }

            }
            catch 
            {
                Console.WriteLine("The process failed.");
            }

            Console.WriteLine(@"Enter the folder numbers:");
            int select = Convert.ToInt32(Console.ReadLine());
            string targetDirectory = dirеctory[select];


            try
            {

                string[] fls = Directory.GetFiles(targetDirectory, "*");
                Array.Sort(fls);
                Console.WriteLine("The number of files is {0}.", fls.Length);
                foreach (string fl in fls)
                {
                    Console.WriteLine(fl);
                }
            }
            catch 
            {
                Console.WriteLine("The process failed.");
            }
        }
    }
}
