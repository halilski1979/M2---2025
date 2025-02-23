namespace P13___Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listEmail = Console.ReadLine().Split('@').ToList();
            string first = listEmail[0];
            string second = listEmail[1];

            Email(first, second);
        }

        private static void Email(string first, string second)
        {
            int s1 = 0;
            int s2 = 0;

            for (int i = 0; i < first.Length; i++)
            {
                s1 = s1 + first[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                s2 = s2 + second[i];
            }

            if (s1 - s2 >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
