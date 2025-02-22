namespace P10___BroynaSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list = new List<int>();

            int br = num[0];
            int number = num[1];

            while (number>0)
            {
                int ost = number % br;
                list.Add(ost);
                number = number / br;
            }

            list.Reverse();
            Console.WriteLine(string.Join("",list));
        }
    }
}
