namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ivan Petrov";
            Console.WriteLine(name);

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            name[0] = "i";
        }
    }
}
