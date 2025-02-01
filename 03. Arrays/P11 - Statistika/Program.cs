using System.Collections.Immutable;

namespace P11___Statistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var  num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"Min = {num.Min()}");
            Console.WriteLine($"Max = {num.Max()}");
            Console.WriteLine($"Sum={num.Sum()}");
            Console.WriteLine($"Average={num.Average():f3}");

            //Сортиране на масив възходящо
            num=num.OrderByDescending(x=>x).ToArray();
            Console.WriteLine(string.Join(" ",num));

            num=num.Distinct().ToArray();
            Console.WriteLine(string.Join(" ", num));

            
        }
    }
}
