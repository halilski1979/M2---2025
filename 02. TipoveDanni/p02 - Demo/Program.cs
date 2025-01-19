namespace p02___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Кастване - преминаване в друг тип
            
            double pi = 3.14;
            int number = (int)(pi);

            Console.WriteLine(pi);
            Console.WriteLine(number);

            double number1 = (double)(number);
            Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine(10/number);
            Console.WriteLine(10/number1);

           
        }
    }
}
