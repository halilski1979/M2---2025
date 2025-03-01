namespace P10___NechetniSreshtaniq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> rechnik = new Dictionary<string, int>();
            var line = Console.ReadLine().ToLower().Split(' ').ToList();

            foreach (var item in line)
            {
                if (rechnik.ContainsKey(item))
                {
                    rechnik[item]++;
                }
                else
                {
                    rechnik[item] = 1;
                }
            }

            foreach (var item in rechnik)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            foreach (var item in rechnik)
            {
                if (item.Value%2==1)
                {
                    Console.Write($"{item.Key}, ");
                }
                
            }
        }
    }
}
