namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Деклариране на списък
           
            List<int> num=new List<int>() {2,3,5,1,8,23,34,55 };
            var names=new List<string>() {"Ivan","Petar","Hristo","Iva"};
            
                       

            Console.WriteLine(string.Join(" ", num));
            Console.WriteLine(string.Join(" ", names));



            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]}");
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"names[{i}]={names[i]}");
            }

        }
    }
}
