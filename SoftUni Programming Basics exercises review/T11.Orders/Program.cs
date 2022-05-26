using System;

namespace T11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfOrders = int.Parse(Console.ReadLine());
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());

            double priceForOrder = 0;
            double sumPriceForOrder = 0;
            int counterOrders = 0;
            double totalPriceForOrders = 0;
            while (counterOrders<numOfOrders)
            {
                counterOrders++;
                if (counterOrders>1)
                {
                    pricePerCapsule = double.Parse(Console.ReadLine());
                    days = int.Parse(Console.ReadLine());
                    capsulesCount = int.Parse(Console.ReadLine());
                }
                priceForOrder = ((days * capsulesCount) * pricePerCapsule);
                sumPriceForOrder += priceForOrder;
                Console.WriteLine($"The price for the coffee is: ${sumPriceForOrder:f2}");
                totalPriceForOrders += sumPriceForOrder;
                  sumPriceForOrder= 0;
                
                
            }
            Console.WriteLine($"Total: ${totalPriceForOrders:f2}");
        }
    }
}
