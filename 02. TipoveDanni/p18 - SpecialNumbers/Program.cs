namespace p18___SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                   
            
            
            for (int i = 1; i < n; i++)
            {
                int s = SborCifri(i);
                
                if (s==5 || s==7 || s==11)
                {
                    Console.WriteLine($"{i} => True");
                }
                else
                {
                    Console.WriteLine($"{i} => False");
                }
            }
        }

        private static int SborCifri(int n)
        {

            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }
    }
}
