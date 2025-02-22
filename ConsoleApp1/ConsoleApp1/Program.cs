using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            string name = "Ivan";
            Console.WriteLine(name);

            //name[0] = 'a';
            Console.WriteLine(name[0]);
            string ime1 = Console.ReadLine();
            StringBuilder ime = new StringBuilder(ime1);
            Console.WriteLine(ime);
            ime[3] = 'a';
            Console.WriteLine(ime);
            ime.Append(" Kosmopolitan");
            Console.WriteLine(ime);
            ime.Insert(5,",");
            Console.WriteLine(ime);
            ime.AppendLine();
            ime.Replace("Halal","Petar");
            Console.WriteLine(ime);
        }
    }
}
