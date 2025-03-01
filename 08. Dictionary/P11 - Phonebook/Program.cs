namespace P11___Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phonebook =new Dictionary<string, string>();

            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                var comand = line[0];
                if (comand=="END")
                {
                    break;
                }

                if (comand=="A")
                {
                    var name = line[1];
                    var phoneNumber = line[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phoneNumber;
                    }
                    else
                    {
                        phonebook[name]= phoneNumber;
                    }
                }

                if (comand == "S")
                {
                    var name = line[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} => {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist!");
                    }
                }
                if (comand == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }


        }
    }
}
