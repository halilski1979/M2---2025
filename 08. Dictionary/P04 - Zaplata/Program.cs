namespace P04___Zaplata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var salary =new Dictionary<string, double>();

            Console.Write("Broy hora: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split(' ').ToArray();
                var name = cmd[0];
                var money = double.Parse(cmd[1]);

                if (salary.ContainsKey(name))
                {
                    salary[name] +=money;
                }
                else
                {
                    salary.Add(name, money);
                }
            }

            foreach (var item in salary)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
