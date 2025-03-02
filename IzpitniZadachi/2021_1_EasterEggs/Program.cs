using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_1_EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string egg;
            int brRed = 0, brOrange = 0, brBlue = 0, brGreen = 0;
            int maxBr = 0;
                //maxBr1 = 0,maxBr2 = 0;
            int br = int.Parse(Console.ReadLine());

            for (int i = 0; i < br; i++)
            {
                egg = Console.ReadLine();
                if (egg=="red")
                {
                    brRed++;
                }
                if (egg == "orange")
                {
                    brOrange++;
                }
                if (egg == "blue")
                {
                    brBlue++;
                }
                if (egg == "green")
                {
                    brGreen++;
                }

            }
            int maxBr1 = Math.Max(brRed,brOrange);
            int maxBr2 = Math.Max(brBlue, brGreen);
            maxBr = Math.Max(maxBr1,maxBr2);
            Console.WriteLine($"Red eggs: {brRed}");
            Console.WriteLine($"Orange eggs: {brOrange}");
            Console.WriteLine($"Blue eggs: {brBlue}");
            Console.WriteLine($"Green eggs: {brGreen}");
            if (brRed==maxBr)
            {
                Console.WriteLine($"Max eggs: {brRed} -> red");
            }
            else if (brOrange==maxBr)
            {
                Console.WriteLine($"Max eggs: {brOrange} -> orange");
            }
            else if (brBlue==maxBr)
            {
                Console.WriteLine($"Max eggs: {brBlue} -> blue");
            }
            else
            {
                Console.WriteLine($"Max eggs: {brGreen} -> green");
            }

        }
    }
}
