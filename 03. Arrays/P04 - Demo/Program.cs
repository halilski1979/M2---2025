namespace P04___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Методи в масиви
            var num = new int[] {1,2,3,4,5,6,7 };

            //1 начин за сума 
            int s = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]%2==0)
                    Console.WriteLine(num[i]);
            }
            Console.WriteLine(s);

            Console.WriteLine($"S={num.Sum()}");
        }
    }
}
