using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_111
{
    class Program
    {
        static void Main(string[] args)
        {
            int brDrehi = int.Parse(Console.ReadLine());

            int tshirt = 20;
            int jeans = 50;
            int trainers = 70;
            int jacket = 60;

            double s = 0;

            for (int i = 0; i < brDrehi; i++)
            {
                string ured = Console.ReadLine();
                if (ured == "t-shirt")
                {
                    s += tshirt;
                }
                if (ured == "jeans")
                {
                    s += jeans;
                }
                if (ured == "trainers")
                {
                    s += trainers;
                }
                if (ured == "jacket")
                {
                    s += jacket;
                }
            }

            Console.WriteLine($"{s:f2}");
        }
    }
}
