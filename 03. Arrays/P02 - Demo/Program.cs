namespace P02___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вход на елементи на различни редове

            Console.Write("Broy elementi: ");
            int br = int.Parse(Console.ReadLine());

            var num = new int[br];


            for (int i = 0; i < br; i++)
            {
                Console.Write($"A[{i}]="); 
                int number= int.Parse(Console.ReadLine());
                num[i] = number;
            }

            Console.WriteLine("========");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"A[{i}]={num[i]}");
            }
        }
    }
}
