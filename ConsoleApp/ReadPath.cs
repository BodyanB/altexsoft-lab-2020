
using System;

namespace ConsoleApp
{
    public interface IAction
    {
        public void ToDo(string path);
    }
    public class Input
    {
        public string InputPath()
        {
            Console.WriteLine("Введите путь:");
            return Console.ReadLine();
        }
    }
}
