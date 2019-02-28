using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                System.Console.WriteLine("Hello World!{ 0}is{ 1}", args[0], args[1]);
            }
            else
            {
                System.Console.WriteLine("Hello World");
            }
            Console.BackgroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Hello World!");
            Console.ResetColor();
            System.Console.WriteLine("Hello World");

            Console.ReadLine();
            
        }
    }
}
;;