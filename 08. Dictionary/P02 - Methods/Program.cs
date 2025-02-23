using System;

namespace P02___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, int>();

            phonebook["Ivan"] = 1213131;
            phonebook["Petar"] = 44553535;

            phonebook.Add("Petq", 3454534);
            phonebook.Add("Rosen",2332323);

            //Печат на речник
            foreach (var item in phonebook)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            phonebook.Remove("Petq");
            Console.WriteLine();

            foreach (var element in phonebook)
            {
                Console.WriteLine($"{element.Key} => {element.Value}");
            }

            Console.WriteLine(new string('-',20));
            phonebook.Clear();
            foreach (var element in phonebook)
            {
                Console.WriteLine($"{element.Key} => {element.Value}");
            }

            




        }


    }
}
