using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_2_FitnessVisitors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> visitors = new List<string>();
            //visitors = Console.ReadLine().Split(',',' ').ToList();
            visitors = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (true)
            {
                
                if (command=="END")
                {
                    break;
                }

                if (command=="Add visitor")
                {
                    var name = Console.ReadLine();
                    visitors.Add(name);
                }

                if (command=="Add visitor on position")
                {
                    var name = Console.ReadLine();
                    var pos = int.Parse(Console.ReadLine());
                    visitors.Insert(pos,name);
                }

                if (command == "Remove visitor on position")
                {
                    var pos = int.Parse(Console.ReadLine());
                    visitors.RemoveAt(pos);
                }

                if (command=="Remove last visitor")
                {
                    visitors.RemoveAt(visitors.Count-1);
                }

                if (command == "Remove first visitor")
                {
                    visitors.RemoveAt(0);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(",",visitors));
            
        }
    }
}
