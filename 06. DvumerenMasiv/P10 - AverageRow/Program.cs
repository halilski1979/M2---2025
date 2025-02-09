namespace P10___AverageRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broy redove");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Broy koloni");
            int m = int.Parse(Console.ReadLine());


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


            for (int i = 0; i < n; i++)
            {
                double s = 0;
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{0,8}" + intMatrix[i, j]);
                    s += intMatrix[i, j];
                }

                Console.WriteLine("{0, 8}", s / m);
                Console.WriteLine();
            }
        }
    }
}
