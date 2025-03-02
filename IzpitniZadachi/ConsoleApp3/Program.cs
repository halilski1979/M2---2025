namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Задача 4 - 2019            
            
            var footbalTeam=new SortedDictionary<string, int>();

            while (true)
            {
                var player = Console.ReadLine().Split('-').ToList();

                string name = player[0];
              

                if (player[0]== "End of season")
                {
                    break;
                }

                int goals = int.Parse(player[1]);
                if (footbalTeam.ContainsKey(name))
                    {
                        footbalTeam[name] += int.Parse(player[1]);
                    }
                    else
                    {
                        footbalTeam.Add(name, goals);
                    }
                             
            }

            foreach (var item in footbalTeam)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
