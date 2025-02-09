namespace P000___DemoBrSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
           double s = 0;
            int stepen = 0;
            while (number > 0)
            {
                s = s + (number % 10) * Math.Pow(n,stepen);
                stepen++;
                number = number / 10;
            }

            Console.WriteLine(s);
        }
    }
}
