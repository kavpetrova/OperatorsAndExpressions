/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/
using System;

class FourDigit
{
    static void Main()
    {
        Console.Write("Enter four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        int FourthNumber = number % 10;             // last number
        int ThirdNumber = (number / 10) % 10;       // third number
        int SecondNumber = (number / 100) % 10;     // second number
        int FirshtNumber = (number / 1000) % 10;    // firsht number
        int sumOfDigits = FourthNumber + ThirdNumber + SecondNumber + FirshtNumber;

        Console.WriteLine("Sum of digits is: {0}", sumOfDigits);
        Console.WriteLine("Reversed number is: {0}{1}{2}{3}", FourthNumber, ThirdNumber, SecondNumber, FirshtNumber);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", FourthNumber, FirshtNumber, SecondNumber, ThirdNumber);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", FirshtNumber, ThirdNumber, SecondNumber, FourthNumber);
    }
}

