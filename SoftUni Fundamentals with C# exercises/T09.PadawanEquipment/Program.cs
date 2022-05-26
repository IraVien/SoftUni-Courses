using System;

namespace T09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double priceOf1Saber = double.Parse(Console.ReadLine());
            double priceOf1Robe = double.Parse(Console.ReadLine());
            double priceOf1Belt = double.Parse(Console.ReadLine());

            double totalNumbersOfSabers = Math.Ceiling(numOfStudents + (numOfStudents * 0.10));//0.10 може да се запише и като 1.10*numOfStudents
            double numberOfFreeBelts = Math.Floor(numOfStudents / 6.0);

            double finalPriceForSabers = totalNumbersOfSabers * priceOf1Saber;
            double finalPriceForRobes = numOfStudents * priceOf1Robe;
            double finalPriceForBelts = (numOfStudents - numberOfFreeBelts) * priceOf1Belt;

            double totalFinalPrice = finalPriceForSabers + finalPriceForRobes + finalPriceForBelts;

            if (amountOfMoney>=totalFinalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalFinalPrice - amountOfMoney):f2}lv more.");
            }


        }
    }
}
