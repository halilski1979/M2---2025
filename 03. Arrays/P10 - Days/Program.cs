﻿namespace P10___Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
                        "Monday",
                        "Tuesday",
                        "Wednesday",
                        "Thursday",
                        "Friday",
                        "Saturday",
                        "Sunday"
                             };

            int day = int.Parse(Console.ReadLine());
            if (day>=1&&day<=7)
            {
                Console.WriteLine(days[day-1]);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
