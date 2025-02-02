namespace P15___SumReversedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').ToList();

            Console.WriteLine(string.Join(" ",num));

            for (int i = 0; i < num.Count; i++)
            {
                num[i] = string.Join("", num[i].Reverse());
            }
            Console.WriteLine(string.Join(" ", num));

            var newNum=num.Select(int.Parse).ToList();
            int s=newNum.Sum();
            Console.WriteLine(s);
        }
    }
}
