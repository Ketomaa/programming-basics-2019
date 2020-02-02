using System;

namespace Kansallinen_Viitenumero
{
    class Program
    {
        static void Intro()
        {
            Console.WriteLine("Syötä 1 niin tarkistan kotimaisen viitenumeron! \n" +
                "Syötä 2 niin luon kotimaisen viitenumeron!");
            Console.Write("Syötä numero mitä haluat, että teen ja paina enter: ");
        }

        static void Main(string[] args)
        {
            Intro();
            int setting;
            do
            {
                setting = int.Parse(Console.ReadLine());
                switch (setting)
                {
                    case 1:
                        RefNumCheck();
                        break;
                    case 2:
                        RefNumCreate();
                        break;
                    default:
                        Console.Write("Error! \n" + "Yritä uudelleen valitsemalla 1 tai 2 ja paina enter: ");
                        break;
                }
            } while (setting != 1 || setting != 2);

        }
        
        static void RefNumCheck()
        {
            string refNum = InputNum();
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] refArr = new int[refNum.Length];
            for (int i = 0; i < refNum.Length; i++)
            {
                refArr[i] = int.Parse(refNum[i].ToString());
            }
            for (int i = 0; i < refArr.Length - 1; i++)
            {
                sum += refArr[refArr.Length - 2 - i] * multiplier[i % 3];
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }

            if (refArr[refArr.Length - 1] == checkNum)
            {
                Console.WriteLine($"\nViitenumerosi {refNum} on oikein!");
            }
            else
            {
                Console.WriteLine($"\nViitenumerosi {refNum} on väärin!");
            }
        }
       

        static string InputNum()
        {
            string input = "placeholder";
            int inputNum = 0;
            do
            {
                Console.Write("Syötä minulle viitenumero, joka on  4-20 numeroa pitkä: ");
                input = Console.ReadLine();
            } while (input.Length <= 3 || input.Length >= 21 || !Int32.TryParse(input, out inputNum) || inputNum < 0);
            return input;
        }
        

        static void RefNumCreate()
        {

            string refNumInput;
            do
            {
                Console.Write("Syötä minulle viitenumeron alkuosa, joka on 3-19 numeroa pitkä: ");
                refNumInput = Console.ReadLine();
            } while (refNumInput.Length <= 2 || refNumInput.Length >= 20);
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] refArr = new int[refNumInput.Length];
            for (int i = 0; i < refNumInput.Length; i++)
            {
                refArr[i] = int.Parse(refNumInput[i].ToString());
            }
            for (int i = 0; i < refArr.Length; i++)
            {
                sum += refArr[refArr.Length - 1 - i] * multiplier[i % 3];
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }
            
            string refNumOutput = refNumInput + checkNum;
            for (int i = 1; i < refNumOutput.Length; i++)
            {
                if (i % 5 == 0)
                {
                    refNumOutput = refNumOutput.Insert(i, " ");
                }
            }
            Console.WriteLine($"\nViitenumerosi alkuosan ({refNumInput}) pohjalta uusi viitenumerosi: {refNumOutput}.");
        }




    }
}
