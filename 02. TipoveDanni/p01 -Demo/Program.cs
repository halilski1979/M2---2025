namespace p01__Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            float number1 = float.Parse(Console.ReadLine());
            
            float floatPI = 3.141592653589793238f;

            Console.WriteLine(Math.Round(floatPI));
            Console.WriteLine(Math.Round(floatPI,3));
            Console.WriteLine($"{floatPI:f4}");
            Console.WriteLine(Math.Floor(floatPI)) ;
            Console.WriteLine(Math.Ceiling(floatPI));
        }
    }
}
