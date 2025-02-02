namespace P16____SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            num=num.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join("<=",num));
        }
    }
}
