namespace P05___RemoveAt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //RemoveAt(index) премахва елемент по неговия индекс

            List<int> num = new List<int>() { 2, 3, 5, 1, 8, 23, 34, 55, 2 };
            var names = new List<string>() { "Ivan", "Petar", "Hristo", "Iva", "Petar" };
            var symbols = new List<char>() { 'A', ',', '1', '!', '1' };

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine(string.Join(" ", symbols));
            Console.WriteLine();

            num.RemoveAt(0);
            names.RemoveAt(names.Count()-1);
            symbols.RemoveAt(1);

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine(string.Join(" ", symbols));
            Console.WriteLine();


        }
    }
}
