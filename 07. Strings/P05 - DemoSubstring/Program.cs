namespace P05___DemoSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //str.Substring(int startIndex, int length)

            string filename = @"C:\Pics\Rila2017.jpg";
            string newStr = filename.Substring(8);
            Console.WriteLine(newStr);

            string newStr1=filename.Substring(8,4);
            Console.WriteLine(newStr1);
        }
    }
}
