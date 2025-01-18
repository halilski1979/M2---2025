namespace p13___DeleneChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                s += a % b;

                Console.WriteLine($"{a}%{b}={a%b}");
            }
            Console.WriteLine(s);
        }
    }
}
