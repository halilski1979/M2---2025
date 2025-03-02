using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача2 - 2019
            
            var visitors = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            

            while (true)
            {
                var command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }

                if (command== "Add visitor")
                {
                    string name = Console.ReadLine();
                    visitors.Add(name);
                }

                if (command== "Add visitor on position")
                {
                    string name = Console.ReadLine();
                    int position = int.Parse(Console.ReadLine());
                    visitors.Insert(position, name);
                }

                if (command== "Remove visitor on position")
                {
                    int position = int.Parse(Console.ReadLine());
                    visitors.RemoveAt(position);
                }

                if (command== "Remove last visitor")
                {
                    visitors.RemoveAt(visitors.Count()-1);
                }

                if (command== "Remove first visitor")
                {
                    visitors.RemoveAt(0);
                }
            }

            foreach (var item in visitors)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
