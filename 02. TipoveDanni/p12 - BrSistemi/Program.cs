namespace p12___BrSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var hex=Convert.ToString(number,16).ToUpper();
            Console.WriteLine(hex);

            var bin=Convert.ToString(number,2);
            Console.WriteLine(bin);



        }
    }
}
