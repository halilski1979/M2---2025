using System.Text;

namespace P09___StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append("Hello Maria, how are you?");
            Console.WriteLine(builder); // Hello Maria, how are you?

            Console.WriteLine(builder.Capacity);
            Console.WriteLine(builder.Length);

            builder[6] = 'D';
            Console.WriteLine(builder);

            builder.Remove(5, 6);
            Console.WriteLine(builder);

            builder.Insert(5, " Peter");
            Console.WriteLine(builder);

            builder.Replace("Peter", "George");
            Console.WriteLine(builder);
        }
    }
}
