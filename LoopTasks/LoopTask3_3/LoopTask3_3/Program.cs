using System;

namespace LoopTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;

            Console.WriteLine("Laskee parillisten ja parittomien lukujen summan");
            Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());

            while (i <= number)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;  
                }
                else
                {
                    oddSum = oddSum + i;
                }
                i++;
            }
            Console.WriteLine($"Parillisten summa = {evenSum}");
            Console.WriteLine($"Parittomien summa = {oddSum}");
        }
    }
}
