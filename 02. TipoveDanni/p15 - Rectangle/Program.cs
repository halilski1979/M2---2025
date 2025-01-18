namespace p15___Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(a * b);
            Console.WriteLine(2*a+2*b);
            Console.WriteLine(Math.Sqrt(a*a+b*b));
        }
    }
}
