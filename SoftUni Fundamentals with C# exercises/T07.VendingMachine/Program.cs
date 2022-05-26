using System;

namespace T07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double accumulatedMoney = 0;
            while (command != "Start")
            {
                double inputMoney = double.Parse(command);
                if (inputMoney == 0.1 || inputMoney==0.2 || inputMoney==0.50 || inputMoney==1 || inputMoney==2)
                {
                    accumulatedMoney += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accpet {inputMoney}");
                }
                command = Console.ReadLine();
                
            }
            command = Console.ReadLine();
            double totalPrice = 0;
            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        totalPrice = 2;
                        break;
                    case "Water":
                        totalPrice = 0.70;
                        break;
                    case "Crisps":
                        totalPrice = 1.50;
                        break;
                    case "Soda":
                        totalPrice = 0.80;
                        break;
                    case "Coke":
                        totalPrice = 1.0;
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;

                }
                if (accumulatedMoney >= totalPrice)
                {
                    accumulatedMoney -= totalPrice;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {accumulatedMoney:f2}");
        }
    }
}
