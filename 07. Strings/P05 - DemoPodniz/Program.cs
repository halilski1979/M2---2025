namespace P05___DemoPodniz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //str.IndexOf(string term) – връща индекса на първия символ или -1
            string email = "vasko@gmail.org";
            int firstIn = email.IndexOf("@");
            Console.WriteLine(firstIn);

            int secondIndex = email.IndexOf("a", 2);
            Console.WriteLine(secondIndex);

            int notFound=email.IndexOf("p");
            Console.WriteLine(notFound);



        }
    }
}
