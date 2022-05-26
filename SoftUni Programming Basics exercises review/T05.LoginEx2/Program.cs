using System;
using System.Text;

namespace T05.LoginEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length-1; i >=0; i--)
            {
                password += username[i];
            }
            int counterPassTimes = 0;
            string inputPassword = Console.ReadLine();
            while (inputPassword!=password)
            {
                counterPassTimes++;
                if (counterPassTimes>3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }
            if (inputPassword==password)
            {
                Console.WriteLine($"User {username} logged in.");
            }

        }

    }
}
