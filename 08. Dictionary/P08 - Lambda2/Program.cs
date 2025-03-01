
using System.Threading.Tasks.Dataflow;

namespace P08___Lambda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Distinct() извлича уникалните елементи от колекция:

            int[] nums = { 1, 2, 2, 3, 4, 5, 6, -2, 2, 0, 15, 3, 1, 0, 6 };
            Console.WriteLine(string.Join(" ",nums));
            nums = nums.Distinct().ToArray();
            Console.WriteLine(string.Join(" ", nums));

            int first=nums.FirstOrDefault();
            Console.WriteLine(first);
            int last=nums.LastOrDefault();
            Console.WriteLine(last);


            int[] number = { 1, 2, 3, 4, 5, 6 };
            int[] otherNums = { 7, 8, 9, 0 };
            var myNumber = number.Concat(otherNums);
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", number));
            Console.WriteLine(string.Join(" ", otherNums));
            Console.WriteLine(string.Join(" ",myNumber));

        }
    }
}
