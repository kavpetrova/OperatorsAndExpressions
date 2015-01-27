/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.*/
using System;

class Trap
{
    static void Main()
    {
        Console.Write("Please enter number for a side: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter number for b side: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter number for h height: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("The trapecoid's area is --> " + ((a + b) * h) / 2);
      



    }
}

