/*Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n <= 100) is prime 
(i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive*/
using System;

class PrintNumber
{
    static void Main()
    {
        Console.Write("Enter positive integer number (between 0 and 100): ");
        int number = int.Parse(Console.ReadLine());
        bool isTrue = true;

        Console.Write("The number is prime: --> ");
        if (number > 1 && number <= 100)
        {
            for (int i = 2; i < 10; i++)
            {
                if (number != i)
                {
                    if (number % i == 0)
                    {
                        isTrue = false;
                    }
                }

            }
            Console.WriteLine(isTrue);
        }
        else
        {
            Console.WriteLine(isTrue = false);
        }
    }
}

