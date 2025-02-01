namespace P03___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вход на елементи от 1 ред
            int [] num=Console.ReadLine().Split(',',' ','-','!').Select(int.Parse).ToArray();

            
            
            //Печат 1 начин
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]}");
            }

            Console.WriteLine("=============");
            //Печат 2 начин
            Console.WriteLine(string.Join(" ",num));

            Console.WriteLine("=============");
            //Печат 3 начин
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
