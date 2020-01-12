using System;

namespace LoopTask4_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tulostaa vakioveikkauksen rivin: ");

            int n = 1;
            double number;
            Random rnd = new Random();
            rnd.NextDouble();
            while (n < 14)
            {
                number = rnd.NextDouble();
                if (number < 0.60)
                {
                    if (number < 0.4)
                    {
                        Console.WriteLine("{0}. 1", n);
                        _ = n + 1;
                    }
                    else
                    {
                        Console.WriteLine("{0}. X", n);
                        _ = n + 1;
                    }
                }
                else
                {
                    Console.WriteLine("{0}. 2", n);
                    _ = n + 1;
                }
                n++;
            }
        }
    }
}
