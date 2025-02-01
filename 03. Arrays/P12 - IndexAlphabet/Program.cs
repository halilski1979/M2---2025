namespace P12___IndexAlphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new char[26];
            int index = 0;

            for (char i = 'a'; i <='z'; i++)
            {
                alphabet[index] = i;
                index++;
            }

           // Console.WriteLine(string.Join(" ",alphabet));
           string word=Console.ReadLine().ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }
            }
           
        }
    }
}
