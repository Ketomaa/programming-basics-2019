﻿using System;

namespace LoopTask4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int times_table = 1;
            int number = 1;
            int end_number;
            Console.WriteLine("Kertotaulu luvuille 1-9:");
            while (times_table < 10)
            {
                while (number < 10)
                {
                    end_number = times_table * number;
                    Console.WriteLine("{0} x {1} = {2}", times_table, number, end_number);
                    number++;
                }
                times_table++;
                number = 1;
            }
        }
    }
}
