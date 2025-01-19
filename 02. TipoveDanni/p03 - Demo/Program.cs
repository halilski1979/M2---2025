namespace p03___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine($"{symbol} decimal=>{(int)(symbol)} =>hex " +
                $"{Convert.ToString((int)(symbol),16).ToUpper()}");


        }
    }
}
