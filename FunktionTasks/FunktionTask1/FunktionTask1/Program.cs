﻿using System;

namespace FunktionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            Console.WriteLine("Syötä luku: ");
            userinput = Convert.ToInt32(Console.ReadLine());
            string funktio = new string('*', userinput);
            Console.WriteLine(funktio);
        }
    }
}
