using System;

namespace check_if_anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Listen";
            string word2 = "Silent";


            int result = (CheckIfAnagram(word1, word2));

            Console.WriteLine(result);

        }

        static int CheckIfAnagram(string word1, string word2)
        {
            char[] temp = word1.ToLower().ToCharArray();
            char[] temp2 = word2.ToLower().ToCharArray();

            Array.Sort(temp);
            Array.Sort(temp2);

            string newWord1 = new string(temp);
            string newWord2 = new string(temp2);
            

            Console.WriteLine(newWord1 + "\t" + newWord2);

            if(newWord1==newWord2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
