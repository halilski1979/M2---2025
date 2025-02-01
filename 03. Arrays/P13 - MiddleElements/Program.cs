namespace P13___MiddleElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (num.Length==1)
            {
                Console.WriteLine(num[0]);
            }
            else if (num.Length%2==0)
            {
                Console.Write("{ " +num[num.Length/2-1] + ", ");
                Console.WriteLine(num[num.Length / 2] +" }");
            }
            else if (num.Length % 2 == 1)
            {
                Console.Write("{ " + num[num.Length / 2 - 1] + ", ");
                Console.Write(num[num.Length / 2] + ", ");
                Console.WriteLine(num[num.Length / 2 + 1]+" }");
            }
        }   
    }
}
