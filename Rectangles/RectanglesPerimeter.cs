using System;
/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.*/
    class RectanglesPerimeter
    {
        static void Main()
        {
            Console.Write("Please enter value for width: ");
            double widht = double.Parse(Console.ReadLine());
            Console.Write("Please enter value for height: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * (widht + height);
            double area = widht * height;

            Console.WriteLine("Perimeter: {0}", perimeter);
            Console.WriteLine("Area: {0}", area);
        }
    }

