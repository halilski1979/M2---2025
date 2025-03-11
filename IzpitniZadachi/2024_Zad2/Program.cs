namespace _2024_Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();

           
            while (true)
            {

                var command = Console.ReadLine().Split(" - ").ToList();
                if (command[0]=="End")
                {
                    break;
                }
                
                string action = command[0];
                string phone = command[1];

                if (action == "Add")
                {
                    if (!phones.Contains(phone))
                    {
                        phones.Add(phone);
                    }
                }

                else if (action == "Remove")
                {
                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                    }                   
                }

                else if (action == "Bonus phone")
                {
                    string[] phoneParts = phone.Split(":");
                    string oldPhone = phoneParts[0];
                    string newPhone = phoneParts[1];

                    int index = phones.IndexOf(oldPhone);
                    if (index != -1)
                    {
                        phones.Insert(index + 1, newPhone);
                    }
                }

                else if (action == "Last")
                {
                    if (phones.Remove(phone))
                    {
                        phones.Add(phone);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
