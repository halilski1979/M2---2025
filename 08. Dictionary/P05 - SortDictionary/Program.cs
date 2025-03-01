using System.Security;

namespace P05___SortDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Dictionary<string, double>();

            while (true)
            {
                var cmd = Console.ReadLine().Split(' ').ToList();

                if (cmd[0]=="END")
                {
                    break;
                }

                var name = cmd[0];
                var ocenka = double.Parse(cmd[1]);
                if (student.ContainsKey(name))
                {
                    student[name] = ocenka;
                }
                else
                {
                    student.Add(name,ocenka);
                }
            }

            foreach (var item in student)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            Console.WriteLine();

            var newStudent = student.OrderByDescending(x => x.Value).ThenByDescending(x=>x.Key).ToDictionary(x=>x.Key,y=>y.Value);
            foreach (var item in newStudent)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
