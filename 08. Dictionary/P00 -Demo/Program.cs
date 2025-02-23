namespace P00__Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new int[10];
            var phonebook = new Dictionary<string,int>();

            num[0] = 12;
            num[1] = 23;

            phonebook["Ivan"] = 1213131;
            phonebook["Petar"] = 44553535;

            phonebook.Add("Petq",3454534);


            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            foreach (var item in phonebook)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

                       
            Console.WriteLine(string.Join(" ", phonebook.Keys));
            Console.WriteLine(string.Join(" ",phonebook.Values));

            Console.WriteLine(phonebook.Count);

        }
    }
}
