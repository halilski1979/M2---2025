namespace P11___Names1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(',').ToList();

            names.Reverse();

            Console.WriteLine(string.Join(" ",names));
            
            
            foreach (var item in names)
            {
                var reversedNames=item.Split(' ').Reverse().ToList();
                Console.WriteLine(string.Join(" ", reversedNames));
            }

            

        }
    }
}
