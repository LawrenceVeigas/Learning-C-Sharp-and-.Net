using System;
using static System.Console;

namespace chapter2_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),
            args[0], true);
            BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),
            args[1], true);
            
            try
            {
                WindowWidth = int.Parse(args[2]);
                WindowHeight = int.Parse(args[3]);
            }
            catch(PlatformNotSupportedException)
            {
                WriteLine("PF not supported");
            }
            WriteLine($"There are {args.Length} arguments.");
            foreach (var arg in args)
            {
            WriteLine(arg);
            }
            
            
        }
    }
}
