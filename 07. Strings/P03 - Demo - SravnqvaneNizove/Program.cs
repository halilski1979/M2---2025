namespace P03___Demo___SravnqvaneNizove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = string.Compare("Petq","Petar",true);
            // result == 0 if str1 equals str2
            // result < 0 if str1 is before str2
            // result > 0 if str1 is after str2
            Console.WriteLine(result);

        }
    }
}
