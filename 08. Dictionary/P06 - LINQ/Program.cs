namespace P06___LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var number=new List<int>() {1,3,6,33,7,8,12};
            Console.WriteLine(string.Join(" ", number));
            Console.WriteLine($"Sum={number.Sum()}");
            Console.WriteLine($"Min={number.Min()}");
            Console.WriteLine($"Max={number.Max()}");
            Console.WriteLine($"Av={number.Average()}");

            number = number.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ",number));
            
            number = number.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ", number));

            //Чрез Take() можем да вземем определен брой елементи:

            var top3 =number.Take(3).ToList();
            Console.WriteLine(string.Join(" ", top3));

            //Чрез Skip() можем да пропуснем определен брой:
            var skip3=number.Skip(3).ToList();
            Console.WriteLine(string.Join(" ", skip3));


        }
    }
}
