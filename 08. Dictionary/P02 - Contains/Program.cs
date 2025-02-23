namespace P02___Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, int>();

            phonebook["Ivan"] = 11111;
            phonebook["Petar"] = 44553535;

            phonebook.Add("Petq", 3454534);
            phonebook.Add("Rosen", 2332323);

            //Печат на речник
            foreach (var item in phonebook)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

           
            
            Console.WriteLine(phonebook.ContainsKey("Iva"));
            Console.WriteLine(phonebook.ContainsValue(11111));
            Console.WriteLine(phonebook.TryGetValue("Ivan", out int number));
            Console.WriteLine(number);

            var result = phonebook["Ivan"];
            Console.WriteLine(result);
        }
    }
}
