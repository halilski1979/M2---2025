using System.Security.Authentication;

namespace P14___Top3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Въведете списък от реални числа и изведете най-големите 3 от тях
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            number = number.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ",number));

        }
    }
}
