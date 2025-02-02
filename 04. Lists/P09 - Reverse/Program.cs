namespace P09___Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse() обръща списъка наобратно
            List<int> num = new List<int>() { 2, 3, 5, 1, 8, 23, 34, 55, 2 };
            var names = new List<string>() { "Ivan", "Petar", "Hristo", "Iva", "Petar" };


            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));

            Console.WriteLine();

            num.Reverse();
            names.Reverse();
            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));

            foreach (var element in num)
            {
                if (element%2==0)
                {
                    Console.WriteLine(element);
                }
            }

            foreach (var item in names)
            {
                if (item.Length<=4)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
