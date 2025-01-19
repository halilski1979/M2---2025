namespace p16___SpeedConvertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double m=double.Parse(Console.ReadLine());
            double s=double.Parse(Console.ReadLine());

            double time = h * 60 * 60 + m * 60 + s;

            Console.WriteLine(Math.Round(meters/time,7));
            Console.WriteLine(Math.Round((meters/1000) / (time/3600), 7));
            Console.WriteLine(Math.Round((meters / 1609) / (time / 3600), 7));
        }
    }
}
