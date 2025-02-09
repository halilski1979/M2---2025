namespace P21___ReversedNumbers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToList(); 

            var result = num.Where(x => x >5 && x%2==0).Reverse().ToList();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
