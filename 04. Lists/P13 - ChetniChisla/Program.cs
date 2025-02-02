namespace P13___ChetniChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            num=num.Where(x => x %2==0).ToList();
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
