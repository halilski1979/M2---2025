namespace P14___Stokcks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stocks=Console.ReadLine().Split(' ').ToArray();
            var quantity=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int index = 0;

            while (true)
            {
                
                string stock = Console.ReadLine();
                if (stock=="Done")
                {
                    break;
                }

                for (int i = 0; i < stocks.Length; i++)
                {
                    if (stock == stocks[i])
                    {
                        index = i; break;
                    }
                }
                Console.WriteLine($"{stocks[index]} costs: {price[index]}; Available quantity: {quantity[index]}");
                Console.WriteLine($"Total money for {stocks[index]} = {price[index] * quantity[index]} lv!");
            }

        }
    }
}
