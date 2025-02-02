namespace P08___Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 2, 3, 5, 1, 8, 23, 34, 55, 2 };
            var names = new List<string>() { "Ivan", "Petar", "Hristo", "Iva", "Petar" };
           

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
           
            Console.WriteLine();


            // num.Sort();
            //names.Sort();

            num=num.OrderBy(x=>x).ToList();
            names=names.OrderByDescending(x=>x).ToList();

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
