namespace P03___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> num = new List<int>() { 2, 3, 5, 1, 8, 23, 34, 55 };
            var names = new List<string>() { "Ivan", "Petar", "Hristo", "Iva" };
            var symbols = new List<char>() { 'A', ',', '1', '!' };

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine(string.Join(" ", symbols));
            Console.WriteLine();

            Console.WriteLine($"CountNum={num.Count()}");
            Console.WriteLine($"CountNNames={names.Count()}");
            Console.WriteLine($"CountSymbols={symbols.Count()}");
        }
    }
}
