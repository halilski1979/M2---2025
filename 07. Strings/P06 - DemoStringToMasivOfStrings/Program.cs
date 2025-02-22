namespace P06___DemoStringToMasivOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listOfBeers = "Amstel.Zagorka Tuborg,Becks.";
            char[] chars = { ',', ' ', '.' };


            string[] beers=listOfBeers.Split(chars);
            Console.WriteLine(string.Join(" ",beers));
            foreach (var item in beers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
