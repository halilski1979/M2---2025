using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_3_SpecialWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            List<string> ednakviBukvi = new List<string>();
            List<string> greaterThan2A = new List<string>();
            List<string> otherWords = new List<string>();
            

            for (int i = 0; i < br; i++)
            {
                int countA = 0;
                var word = Console.ReadLine();
                //Еднакви букви в началото и края
                if (word[0] == word[word.Length - 1])
                {

                    ednakviBukvi.Add(word);
                }

                //С Повече от една "а"
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == 'a')
                    {
                        countA++;
                    }
                   
                }
                Console.WriteLine($"{word}=>{countA}");
                if (countA>=2)
                {
                    greaterThan2A.Add(word);
                }

               
                //Останалите думи
                if (countA<2 && word[0] != word[word.Length - 1])
                {
                    otherWords.Add(word);
                }
                
                
            }
            
            Console.WriteLine(string.Join(",",ednakviBukvi));
            
            Console.WriteLine(string.Join(",", greaterThan2A));
            
            Console.WriteLine(string.Join(",", otherWords));
        }
    }
}
