namespace P02___Ddemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'a', 'b', 'c', 'd' };

            Console.WriteLine(string.Join(" ",chars));
            chars[0] = 'A';
            Console.WriteLine(string.Join(" ", chars));

            //Конвертиране от масив към стринг
            string alphabet = new string(chars);
            Console.WriteLine(alphabet);
            Console.WriteLine();

            //Конвертиране от  стринг към масив
            char[] newChars = alphabet.ToCharArray();
            Console.WriteLine(string.Join(" ", newChars));
            newChars[1] = 'B';
            Console.WriteLine(string.Join(" ", newChars));
        }
    }
}
