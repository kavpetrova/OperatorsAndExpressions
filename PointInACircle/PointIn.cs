/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).*/
using System;

class PointIn
{
    static void Main()
    {
        Console.Write("Please enter the x: ");
        double xPoint = double.Parse(Console.ReadLine());
        Console.Write("Please enter the y: ");
        double yPoint = double.Parse(Console.ReadLine());
        bool InCirle = (Math.Pow(xPoint, 2) + Math.Pow(yPoint, 2)) <= Math.Pow(2, 2);
        Console.WriteLine("Is the point ({0}, {1}) in cirle? --->> {2}", xPoint, yPoint, InCirle);
    }
}

