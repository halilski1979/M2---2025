namespace P00___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Въвеждане на списъци от конзолата
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ",num));

            var names = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine(string.Join(" ", names));

            List<char> symbols = Console.ReadLine().Split(' ').Select(char.Parse).ToList();
            Console.WriteLine(string.Join(" ", symbols));
        }
    }
}
