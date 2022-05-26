using System;

namespace T03.Vacation
using System;

namespace T03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string typeOfDay = Console.ReadLine();
            double priceAll = 0;
            const double priceStudentsFriday = 8.45;
            const double priceStudentsSaturday = 9.80;
            const double priceStudentsSunday = 10.46;
            const double priceBusinessFriday = 10.90;
            const double priceBusinessSaturday = 15.60;
            const double priceBusinessSunday = 16;
            const double priceRegularFriday = 15;
            const double priceRegularSaturday = 20;
            const double priceRegularSunday = 22.50;

            switch (typeOfGroup)
            {
                case "Students":
                    if (typeOfDay == "Friday")
                    {
                        priceAll = priceStudentsFriday * numOfPeople;
                    }
                    else if (typeOfDay == "Saturday")
                    {
                        priceAll = priceStudentsSaturday * numOfPeople;
                    }
                    if (typeOfDay == "Sunday")
                    {
                        priceAll = priceStudentsSunday * numOfPeople;
                    }
                    break;
                case "Business":
                    if (typeOfDay == "Friday")
                    {
                        priceAll = priceBusinessFriday * numOfPeople;
                    }
                    else if (typeOfDay == "Saturday")
                    {
                        priceAll = priceBusinessSaturday * numOfPeople;
                    }
                    if (typeOfDay == "Sunday")
                    {
                        priceAll = priceBusinessSunday * numOfPeople;
                    }
                    break;
                case "Regular":
                    if (typeOfDay == "Friday")
                    {
                        priceAll = priceRegularFriday * numOfPeople;
                    }
                    else if (typeOfDay == "Saturday")
                    {
                        priceAll = priceRegularSaturday * numOfPeople;
                    }
                    if (typeOfDay == "Sunday")
                    {
                        priceAll = priceRegularSunday * numOfPeople;
                    }
                    break;
                default:
                    break;
            }
            if (typeOfGroup == "Students" && numOfPeople >= 30)
            {
                priceAll -= priceAll * 0.15;

            }
            else if (typeOfGroup == "Business" && numOfPeople >= 100)
            {
                priceAll -= priceAll * 0.10;
            }
            if (typeOfGroup == "Regular" && numOfPeople >= 10 && numOfPeople <= 20)
            {
                priceAll -= priceAll * 0.05;
            }
            Console.WriteLine($"Total price: {priceAll:f2}");
        }
    }
}

