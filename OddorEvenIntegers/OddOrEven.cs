using System;
/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.*/
class OddOrEven
{
    static void Main()
    {

        Console.Write("Please enter a number:");
        int number = int.Parse(Console.ReadLine());

        bool odd = number % 2 == 0;

        Console.WriteLine("The number is {0}", odd ? "even" : "odd");

    }
}

