namespace P00___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAll();
        }

       public static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('_',20));
        }

        public static void Body()
        {
            Console.WriteLine("Charged to  "+new string('-',8));
            Console.WriteLine("Received by " + new string('-', 8));
        }

        public static void Footer()
        {
            Console.WriteLine( new string('-', 20));
            Console.WriteLine("SoftUni  ");
        }

        public static void PrintAll()
        {
            Header();
            Body();
            Footer();
        }
    }
}
