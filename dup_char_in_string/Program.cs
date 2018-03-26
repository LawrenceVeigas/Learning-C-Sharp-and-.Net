using System;

namespace dup_char_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = "KingOfTheJungleIsAlive";

            string table = "";
            string without_dup_chars = "";

            foreach (char value in hero)
            {
                if(table.IndexOf(value)==-1)
                {
                    table += value;
                    without_dup_chars += value;
                }
            }
            Console.WriteLine(without_dup_chars);
        }
    }
}
