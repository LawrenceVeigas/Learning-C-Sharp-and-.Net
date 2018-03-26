using System;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Jumanji";

            Console.WriteLine(ReverseStringIterative(word));
            
        }

        static string ReverseStringIterative(string word)
        {
            char[] char_array = word.ToLower().ToCharArray();

            string reversed_word = "";

            for (int i=char_array.Length-1; i>=0; i--)
            {
                reversed_word += char_array[i];
            }

            return reversed_word;
        }

        static string ReverseStringRecursive(string word)
        {
            word = word.ToLower();
            
            
        }
    }
}
