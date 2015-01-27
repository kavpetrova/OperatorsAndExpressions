/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.*/
using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter position: ");
        int p = int.Parse(Console.ReadLine());

        byte PositionP = (byte)((number >> p) & 1);
        Console.WriteLine("bit at #{0} is {1}", p, PositionP);
    }
}

