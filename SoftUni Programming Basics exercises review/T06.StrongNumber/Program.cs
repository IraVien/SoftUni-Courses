using System;

namespace T06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long factorialSum = 0;
            for (int counterNum = 0; counterNum <= number.Length-1; counterNum++)
            {
                char currentCh = number[counterNum];
                int currentDigit = (int)currentCh - 48;

                long currentDigitFactorial = 1;
                for (int reverse = currentDigit; reverse >1; reverse--)
                {
                    currentDigitFactorial *= reverse;
                }
                factorialSum += currentDigitFactorial;
            }
            if (factorialSum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
