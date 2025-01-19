namespace p19___BoolType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            bool boolWord=Convert.ToBoolean(word);
            if (boolWord==true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
