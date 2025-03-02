namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2 - 2020
            var numbers=Console.ReadLine().Split(',').Select(int.Parse).ToList();

            var group1=new List<int>();
            var group2 = new List<int>();
            var group3 = new List<int>();
            int s = 0;

            foreach (var item in numbers)
            {
               
                if (item%10==4 || item%10==8)
                {
                    group1.Add(item);
                }                
                
                
                if (item % 10 == 5 || item % 10 == 7)
                {
                    group2.Add(item);
                }

                //Намира сбора от цифрите на числото
                int num = item;
                while (num>0)
                {
                    s += num % 10;
                    num = num / 10;
                }
                //End
               
                if (s==15)
                {
                    group3.Add(item);
                }
                s = 0;
            }
            
            Console.WriteLine(string.Join(",",group1));
            Console.WriteLine(string.Join(",", group2));
            Console.WriteLine(string.Join(",", group3));
        }
    }
}
