namespace P17___Kvadrati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            num=num.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
