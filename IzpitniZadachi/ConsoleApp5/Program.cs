namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача3 - 2020

            var n = int.Parse(Console.ReadLine());

            var special = new List<string>();
            var others = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                if (char.IsUpper(word[0]) && (word.Contains('i')||word.Contains('I')) && word.Length>7)
                {
                    special.Add(word);
                }
                else
                {
                    others.Add(word);
                }
            }

            Console.Write("Special words: ");
            Console.Write(string.Join(",",special));
            Console.WriteLine();
            Console.Write("Others words: ");
            Console.Write(string.Join(",", others));
            Console.WriteLine();
        }
    }
}
