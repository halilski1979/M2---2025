namespace P19___NumbersCOunt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).OrderBy(x=>x).ToList();              
            var newNums = nums.Distinct().ToList();
           

            int count = 0;

            foreach (var item in newNums)
            {
                count = 0;
                foreach (var elem in nums)
                {
                    if (item==elem)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{item} => {count}");
            }
        }
    }
}
