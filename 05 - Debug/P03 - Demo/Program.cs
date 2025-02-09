namespace P03___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum());
        }

        public static int Sum()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int s = a + b;
            return s;
        }
    }
}
