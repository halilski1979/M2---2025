namespace P08___DemoTrim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //str.Trim() – отрязва празно протранство в началото и края на низ

            string s = "    example of white space    ";
            Console.WriteLine(s);

            string clean = s.Trim();
            Console.WriteLine(clean);


        }
    }
}
