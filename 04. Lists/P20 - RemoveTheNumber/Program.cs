namespace P20___RemoveTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //Вземане на последен елемент - 1 начин
            int n = num[num.Count()-1];
            Console.WriteLine(n);

            //Вземане на последен елемент - 1 начин
            int lastEl=num.LastOrDefault();
            Console.WriteLine(lastEl);
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]==lastEl)
                {
                    num.Remove(lastEl);
                }
            }
           
            Console.WriteLine(string.Join(" ",num));

        }
    }
}
