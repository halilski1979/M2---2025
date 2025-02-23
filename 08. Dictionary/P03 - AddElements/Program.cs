namespace P03___AddElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var namesAge = new Dictionary<string, int>();

            Console.Write("Broy hora: ");
            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmd=Console.ReadLine().Split(' ').ToList();
                var name = cmd[0];
                var age = int.Parse(cmd[1]);

                if (namesAge.ContainsKey(name))
                {
                    namesAge[name] = age;
                }
                else
                {
                    namesAge.Add(name, age);
                }               

                //namesAge.Add(cmd[0], int.Parse(cmd[1]));
            }

            foreach (var elem in namesAge)
            {
                Console.WriteLine($"{elem.Key} == {elem.Value}");
            }
        }
    }
}
