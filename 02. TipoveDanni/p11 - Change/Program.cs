namespace p11___Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");

            int c = a;
            a = b;
            b = c;

            Console.WriteLine();
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }
    }
}
