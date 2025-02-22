namespace P07___DemoReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //str.Replace(match, replacement) – замества всички съвпадения

            string cocktail = "Vodka + Martini + Cherry";
            string newCocktail = cocktail.Replace("+","and");

            Console.WriteLine(cocktail);
            Console.WriteLine(newCocktail);

            string newCock = cocktail.Replace("Vodka","Whyski");
            Console.WriteLine(newCock);


        }
    }
}
