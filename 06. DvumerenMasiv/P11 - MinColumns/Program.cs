namespace P11___MinColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broy redove");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Broy koloni");
            int m = int.Parse(Console.ReadLine());

            int min = int.MaxValue;
            //Вход на елементи на двумерен масив
            int[,] intMatrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"M[{i},{j}]=");
                    intMatrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //Печат на елементи на двумерен масив

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(intMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                min = int.MaxValue;
                for (int j = 0; j < n; j++)
                {
                   
                    if (intMatrix[j, i] < min)
                    {
                        min = intMatrix[j, i];
                    }
                }
                Console.Write(min + " ");
            }
        }
    }
}
