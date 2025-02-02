namespace P04___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Remove(element) премахва първото срещане на елемент (връща true / false)


            List<int> num = new List<int>() { 2, 3, 5, 1, 8, 23, 34, 55,2 };
            var names = new List<string>() { "Ivan", "Petar", "Hristo", "Iva" ,"Petar"};
            var symbols = new List<char>() { 'A', ',', '1', '!','1' };

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine(string.Join(" ", symbols));
            Console.WriteLine();

            num.Remove(2);
            names.Remove("Petar");
            symbols.Remove('1');

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine(string.Join(" ", symbols));
            Console.WriteLine();


        }
    }
}
