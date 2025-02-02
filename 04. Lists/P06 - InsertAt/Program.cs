namespace P06___InsertAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Insert(index, element) вмъква елемент на зададената позиция

            List<int> num = new List<int>() { 2, 3, 5, 1, 8, 23, 34, 55, 2 };
            var names = new List<string>() { "Ivan", "Petar", "Hristo", "Iva", "Petar" };
            var symbols = new List<char>() { 'A', ',', '1', '!', '1' };

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine(string.Join(" ", symbols));
            Console.WriteLine();

            num.Insert(3,1111);
            names.Insert(3,"Dospatliyski");
            symbols.Insert(3,'*');

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine(string.Join(" ", symbols));
            Console.WriteLine();
        }
    }
}
