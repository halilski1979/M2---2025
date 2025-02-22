using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четем входните данни
            string wordToCensor = Console.ReadLine();
            string sentence = Console.ReadLine();

            // Създаваме цензурираната версия на думата (****)
            string censoredWord = new string('*', wordToCensor.Length);

            // Използваме StringBuilder за обработка на текста
            StringBuilder sb = new StringBuilder(sentence);

            // Замяна на всички срещания на думата
            sb.Replace(wordToCensor, censoredWord);

            // Извеждаме резултата
            Console.WriteLine(sb.ToString());
        }
    }
}
