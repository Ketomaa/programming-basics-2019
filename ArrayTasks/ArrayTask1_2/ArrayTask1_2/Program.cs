using System;

namespace ArrayTask1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arpoo 100 lukua väliltä 0-50 ja tulostaa ne sekä antaa niiden keskiarvon");
            int[] numbers = new int[100];
            Random rnd = new Random();
            double sum = 0;
            double average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(50);
                sum += numbers[i];
                Console.WriteLine($"{i + 1}. {numbers[i]}");
            }
            average = sum / numbers.Length;
            Console.WriteLine($"Saatujen tulosten keskiarvo on {average}");
        }
    }
}
