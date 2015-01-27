using System;
/*Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.*/
class ThirdDigit
{
    static void Main()
    {
        Console.Write("Please enter a number:");
        int number = int.Parse(Console.ReadLine());

        bool Seven = (number / 100) % 10 == 7;

        Console.WriteLine("{0}", Seven ? "The third digit is 7" : "The third digit is Not 7");
    }
}

