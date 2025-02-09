namespace P00___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да зададем стойности на многомерния масив веднага след деклариране: 
            int[,] intMatrix1 = { { 2, 8, 3, 5 }, { 7, 9, 0, 3 } };


            //Вход на елементи на двумерен масив
            int[,] intMatrix = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"M[{i},{j}]=");
                    intMatrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('=',20));
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"M[{i},{j}]={intMatrix[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('=', 20));
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($" {intMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            //Брой редове
            Console.WriteLine($"Redove: {intMatrix.GetLength(0)}");

            //Брой колони
            Console.WriteLine($"Koloni: {intMatrix.GetLength(1)}");
        }
    }
}
