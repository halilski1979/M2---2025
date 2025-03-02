using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_1_FitnesUredi
{
    class Program
    {
        static void Main(string[] args)
        {
            int brUredi = int.Parse(Console.ReadLine());
            int treadmill = 5899;
            int crossTrainer = 1699;
            int exrciseBike = 1789;
            int dumbells = 579;

            double s = 0;

            for (int i = 0; i < brUredi; i++)
            {
                string ured = Console.ReadLine();
                if (ured=="treadmill")
                {
                    s += treadmill;
                }
                if (ured=="cross trainer")
                {
                    s += crossTrainer;
                }
                if (ured=="exercise bike")
                {
                    s += exrciseBike;
                }
                if (ured=="dumbbells")
                {
                    s += dumbells;
                }
            }

            Console.WriteLine($"{s:f2}");
        }
    }
}
