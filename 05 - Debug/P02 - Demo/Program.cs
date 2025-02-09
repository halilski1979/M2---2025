namespace P02___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вариант 1 - void  с параметър
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Sum(a,b);
        }

        public static void Sum(int a, int b)
        {
            int s = a + b;
            Console.WriteLine(s);
        }
    }
}
