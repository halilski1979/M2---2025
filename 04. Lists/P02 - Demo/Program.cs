using System.ComponentModel.DataAnnotations;

namespace P02___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Аdd - добавя на последна позиция
            
            List<int> num = new List<int>() { 2, 3, 5, 1, 8, 23, 34, 55 };
            var names = new List<string>() { "Ivan", "Petar", "Hristo", "Iva" };
            var symbols = new List<char>() {'A',',','1','!'} ;

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine();

            num.Add(111);
            names.Add("Dospatliyski");
            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));
            Console.WriteLine();

        }
    }
}
