namespace P10___Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ').ToList();
            names.Reverse();
            Console.WriteLine(string.Join(" | ",names));

        }
    }
}
