﻿namespace P12___IndexAlphabets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {(int)(word[i]-97)}");
            }
        }
    }
}
