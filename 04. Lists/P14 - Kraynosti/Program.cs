namespace P14___Kraynosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var newNum =new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]==num.Min())
                {
                    newNum.Add(num[i]);
                }
            }

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] == num.Max())
                {
                    newNum.Add(num[i]);
                }
            }

            Console.WriteLine(string.Join(" ",newNum));
        }
    }
}
