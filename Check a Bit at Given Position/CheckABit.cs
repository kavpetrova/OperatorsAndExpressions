
/*Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p 
(counting from 0, starting from the right) in given integer number n, has value of 1.*/
using System;

class CheckABit
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        bool positionP = ((number >> p) & 1) == 1;

        Console.WriteLine("Is bit at {0} == 1 --> {1}", p, positionP);
    }
}

