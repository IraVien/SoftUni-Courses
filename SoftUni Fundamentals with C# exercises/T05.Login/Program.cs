using System;

namespace T05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password =string.Empty;
            for (int i = username.Length-1; i >=0; i--)
            {
                password += username[i];
            }
            for (int countTimes = 1; countTimes <=4; countTimes++)
            {
                string enteredPass = Console.ReadLine();
                if (enteredPass==password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (countTimes==4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        continue;
                    }
                }
            }

        }
    }
}
