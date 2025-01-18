namespace p14___SborCifri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SborCifri(n);
        }

        private static void SborCifri(int n)
        {
           
            int s = 0;
            while (n > 0)
            {
                s += n % 10;
                n = n / 10;
            }
            Console.WriteLine(s);
        }
    }
}
