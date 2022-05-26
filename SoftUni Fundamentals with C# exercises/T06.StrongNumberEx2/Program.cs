using System;

namespace T06.StrongNumberEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int strongNumber = int.Parse(Console.ReadLine());
            int strongNumberCopy = strongNumber;
            int sum = 0;

            while (strongNumber>0)
            {
                int factorialNumber = 1;
                int currNum = strongNumber % 10;
                strongNumber /= 10;

                for (int counter = 2; counter <=currNum; counter++)
                {
                    factorialNumber *= counter;
                }
                sum += factorialNumber;
            }
            Console.WriteLine(sum == strongNumberCopy ? "yes" : "no");

        }
    }
}
