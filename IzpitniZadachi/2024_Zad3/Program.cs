namespace _2024_Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                string[] usernames = Console.ReadLine().Split(", ").ToArray();

                foreach (string item in usernames)
                {
                    if (item.Length >= 3 && item.Length <= 16 &&
                       item.All(ch => char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
                    {
                        Console.WriteLine(item);
                    }
                }
           

           
        }
    }
}
