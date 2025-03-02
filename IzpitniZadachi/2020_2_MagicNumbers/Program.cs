using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_2_MagicNumbers
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
            
            //•	Група на четните числа, които завършват на 4 или 8
            var list1 = new List<int>();

            //•	Група на нечетните числа, които завършват на 5 или 7
            var list2 = new List<int>();

            //•	Група на числа, чийто сбор на цифрите е 15
            List<int> list3 = new List<int>();

            foreach (var item in vhod)
            {
                if (item%10==4 || item%10==8)
                {
                    list1.Add(item);
                }

                if (item % 10 == 5 || item % 10 == 7)
                {
                    list2.Add(item);
                }

                if (SumDigit(item)==15)
                {
                    list3.Add(item);
                }

            }

            Console.WriteLine(string.Join(",",list1));
            Console.WriteLine(string.Join(",", list2));
            Console.WriteLine(string.Join(",", list3));
        }
    }
}
