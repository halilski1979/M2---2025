namespace P11___Censur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string censura = Console.ReadLine();
            string izr = Console.ReadLine();

            Censura(censura, izr);
        }

        private static void Censura(string censura, string izr)
        {
            string newIzr = izr.Replace(censura, new string('*', censura.Length));
            Console.WriteLine(newIzr);
        }
    }
}
