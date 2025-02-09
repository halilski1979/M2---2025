namespace P000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int brS=int.Parse(Console.ReadLine());

            var num = new List<int>();

            while (number > 0) 
            {
                int ost = number % brS;
                number = number / brS;
               num.Add(ost);
            }
            num.Reverse();
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
