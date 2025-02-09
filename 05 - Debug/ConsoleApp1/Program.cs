namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int brS = num[0];
            int number = num[1];
            int stepen = 0;
            double s = 0;

            while (number>0)
            {

                int ost = number % 10;
                if (ost>=brS)
                {
                    Console.WriteLine("ERROR");

                    break;
                }
                s = s + (ost) * Math.Pow(brS, stepen);
                stepen++;
                number = number / 10;
            }

            Console.WriteLine(s);
        }
    }
}
