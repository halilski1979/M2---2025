using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_2_Numbers
{
    class Program
    {
        public static int SumDigit(int digit)
        {
            int sum = 0;
            var s = digit.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                sum += int.Parse(s[i].ToString());
            }

            return sum;
        }

        static void Main(string[] args)
        {
            var vhod = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            //•	Група на четните числа
            var list1 = new List<int>();

            //•	Група на нечетните числа
            var list2 = new List<int>();

            //•	Група на числа, чийто сбор на цифрите е 15
            List<int> list3 = new List<int>();

            foreach (var item in vhod)
            {
                if (item % 2 == 0)
                {
                    list1.Add(item);
                }

                if (item % 2 == 1)
                {
                    list2.Add(item);
                }

                if (SumDigit(item)%10 == 5)
                {
                    list3.Add(item);
                }

            }

            Console.WriteLine(string.Join(",", list1));
            Console.WriteLine(string.Join(",", list2));
            Console.WriteLine(string.Join(",", list3));
        }
    }
}
