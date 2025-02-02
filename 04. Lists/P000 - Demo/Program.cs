namespace P000___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                //Console.Write($"num[{i}]=");
                num.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(" ",num));
        }
    }
}
