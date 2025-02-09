namespace P21___RemoveNegativeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num=Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToList();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]<0)
                {
                    num.RemoveAt(i);
                    i--;
                }
            }
            if (num.Count==0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",num));
            }
        }
    }
}
