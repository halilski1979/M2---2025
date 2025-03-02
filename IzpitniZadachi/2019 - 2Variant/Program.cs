namespace _2019___2Variant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> visitors = new List<string>(Console.ReadLine().Split(", "));
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] parts = command.Split();

                switch (parts[0])
                {
                    case "Add":
                        if (parts[1] == "visitor")
                        {
                            string newVisitor = Console.ReadLine();
                            visitors.Add(newVisitor);
                        }
                        else if (parts[1] == "visitor" && parts[2] == "on" && parts[3] == "position")
                        {
                            string newVisitor = Console.ReadLine();
                            int position = int.Parse(Console.ReadLine());
                            if (position >= 0 && position <= visitors.Count)
                            {
                                visitors.Insert(position, newVisitor);
                            }
                        }
                        break;

                    case "Remove":
                        if (parts[1] == "visitor" && parts[2] == "on" && parts[3] == "position")
                        {
                            int position = int.Parse(Console.ReadLine());
                            if (position >= 0 && position < visitors.Count)
                            {
                                visitors.RemoveAt(position);
                            }
                        }
                        else if (command == "Remove last visitor" && visitors.Count > 0)
                        {
                            visitors.RemoveAt(visitors.Count - 1);
                        }
                        else if (command == "Remove first visitor" && visitors.Count > 0)
                        {
                            visitors.RemoveAt(0);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", visitors));
        }
    }
}
