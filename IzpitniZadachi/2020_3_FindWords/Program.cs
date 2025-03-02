using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_3_FindWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> specialWords = new List<string>();
            List<string> otherWords = new List<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                bool isFirstLetterCapital = char.IsUpper(word[0]);
                bool isContainLetterI = (word.IndexOf("i") != -1 || word.IndexOf("I") != -1);
                bool isGreaterThan7 = (word.Length > 7);


                if (isFirstLetterCapital && isContainLetterI && isGreaterThan7)
                {
                    specialWords.Add(word);
                }
                else
                {
                    otherWords.Add(word);
                }
            }

            Console.WriteLine($"Special words: {string.Join(", ",specialWords)}");
            Console.WriteLine($"Other words: {string.Join(", ",otherWords)}");
        }
                               
    }
}
