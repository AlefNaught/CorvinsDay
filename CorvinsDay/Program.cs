using System;
using System.Reflection.Metadata;

namespace CorvinsDay
{
    class Style
    {
        public void Dialog(string dialog)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(dialog);
            Console.ResetColor();
        }
        public void Continue(string forward)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(forward);
            Console.ResetColor();
        }
        public void Description(string description)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(description);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}