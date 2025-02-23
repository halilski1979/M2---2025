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
                int pos = int.Parse(cmd[1]);
                int lenght = int.Parse(cmd[2]);

                sb.Remove(pos,lenght);
                Console.WriteLine(sb.ToString());
            }

            if (cmd[0] == "Insert")
            {
                int pos = int.Parse(cmd[1]);
                string duma = cmd[2];

                sb.Insert(pos, duma);
                Console.WriteLine(sb.ToString());
            }

            if (cmd[0] == "Replace")
            {
                string oldWord = cmd[1];
                string newWord = cmd[2];

                sb.Replace(oldWord, newWord);
                Console.WriteLine(sb.ToString());
            }



        }
    }
}
