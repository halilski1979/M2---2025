using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_4_ShopingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var linia = Console.ReadLine().Split('-').ToList();
            Dictionary<string, double> magazin = new Dictionary<string, double>();
            double sum = 0;
            while (linia[0] != "Stop shopping")
            {

                var stoka = linia[0];
                var price = double.Parse(linia[1]);


                if (magazin.ContainsKey(stoka))
                {
                    magazin[stoka] += price;
                }
                else
                {
                    magazin.Add(stoka, price);
                }



                linia = Console.ReadLine().Split('-').ToList();
            }

            foreach (var item in magazin.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2} ");
                sum+= item.Value;
            }
            Console.WriteLine($"Total sum: {sum:f2}");
        }
    }
}
