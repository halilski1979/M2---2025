namespace P07___Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contains(element) определя дали елемента се съдържа в списъка. Връща TRUE/FALSE


            List<int> num = new List<int>() { 2, 3, 5, 1, 8, 23, 34, 55, 2 };
            var names = new List<string>() { "Ivan", "Petar", "Hristo", "Iva", "Petar" };
            var symbols = new List<char>() { 'A', ',', '1', '!', '1' };

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine(string.Join(" ", symbols));
            Console.WriteLine();

            Console.WriteLine(num.Contains(2));
            Console.WriteLine(names.Contains("Kiril"));
        }
    }
}
