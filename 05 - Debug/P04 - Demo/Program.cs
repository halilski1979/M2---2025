namespace P04___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int sbor = Sum(X,Y);
            Console.WriteLine(sbor);
        }

        public static int Sum(int a,int b)
        {            
            int s = a + b;
            return s;
        }
    }
}
