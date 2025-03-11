namespace _2024_Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int itemCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < itemCount; i++)
            {
                string stoka = Console.ReadLine();
                               

                if (stoka=="bed")
                {
                    totalPrice += 1300;
                }
                else if (stoka== "jacuzzi")
                {
                    totalPrice += 3200;
                }
                else if (stoka == "towel")
                {
                    totalPrice += 10;
                }
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
