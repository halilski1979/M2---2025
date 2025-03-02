namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           //Задача 3 - 2019
            
            int s = 0;
            int sMax = 0;
            string winnerWord = "";

            while (true)
            {                

                string word = Console.ReadLine();
                if (word== "END OF GAME")
                {
                    break;
                }

                for (int i = 0; i < word.Length; i++)
                {
                    s += (int)(word[i]);
                }

                if (char.IsUpper(word[0]))
                {
                    s += 15;
                }

                if (word[word.Count()-1]=='t')
                {
                    s += 20;
                }

                if (word.Length>=10)
                {
                    s += 30;
                }

                if (s>sMax)
                {
                    sMax = s;
                    winnerWord = word;
                }
                s = 0;
            }

            Console.WriteLine($"Winner is word: {winnerWord}");
            Console.WriteLine($"Points: {sMax}");
        }

       
    }
}
