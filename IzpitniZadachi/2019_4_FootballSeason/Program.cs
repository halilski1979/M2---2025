using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_4_FootballSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> statistics = new Dictionary<string, int>();
            var command = Console.ReadLine().Split('-').ToList();

            while (command[0]!="End of season")
            {
                var igrach = command[0];
                var golove = int.Parse(command[1]);

                if (statistics.ContainsKey(igrach))
                {
                    statistics[igrach] += golove;
                }
                else
                {
                    statistics.Add(igrach,golove);
                }
                
                command = Console.ReadLine().Split('-').ToList();
            }

            foreach (var item in statistics.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}->{item.Value}");
            }
        }
    }
}
