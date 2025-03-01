namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(double.Parse);
            
            var counts=new SortedDictionary<double, int>();

            foreach (var item in num)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
            }


            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
