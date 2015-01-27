using System;
/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/
class Gravitation
{
    static void Main()
    {
        Console.Write("Please enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
        double MoonGravity = 0.17;
        double MoonWeight = weight * MoonGravity;
        Console.WriteLine("Your weight on the Moon, will be: {0} kilograms!",MoonWeight);
        Console.WriteLine("Have a nice trip to the Moon :)");
    }
}

