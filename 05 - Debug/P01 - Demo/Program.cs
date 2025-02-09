namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Вариант 1 - void  без параметър
            Sum();
        }

        private static void Sum()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int s = a + b;
            Console.WriteLine(s);
        }

    }
}
