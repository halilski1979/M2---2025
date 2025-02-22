using System.Text;

namespace P12___StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sb = new StringBuilder();
            sb.Append(word);


            List<string> cmd = Console.ReadLine().Split(' ').ToList();

            if (cmd[0]== "Remove")
            {
                sb.Remove(int.Parse(cmd[1]), int.Parse(cmd[2]));
                Console.WriteLine(sb.ToString());
            }

        }
    }
}
