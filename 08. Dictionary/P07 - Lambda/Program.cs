namespace P07___Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(string.Join(" ",nums));
            var newNums = nums.Where(x => x%2==0 && x>2).ToArray();
            Console.WriteLine(string.Join(" ", newNums));


            int count = nums.Count(x=>x%2==0);
            Console.WriteLine($"Count: {count}");

        }
    }
}
