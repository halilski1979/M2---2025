using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            //Еднакви букви в началото и края

            int countA = 0;
            for (int j = 0; j < word.Length ; j++)
            {
                if (word[j] == 'a')
                {
                    countA++;
                }
            }
            Console.WriteLine(countA);
        }
    }
}
