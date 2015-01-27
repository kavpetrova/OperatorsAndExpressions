/*Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and 
out of the rectangle R(top=1, left=-1, width=6, height=2).*/
using System;

class Print
{
    static void Main()
    {
        double raduis = 1.5;
        Console.Write("Enter X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= raduis);
        bool isOutRectangle = (-1 < x) ^ (x > 5) ^ (-1 < y) ^ (y > 1);

        if (isInCircle && isOutRectangle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}

