﻿using System;
/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
by 7 and 5 at the same time.*/
    class Divide
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool Divided = number % 7 == 0 && number % 5 == 0 && number != 0;
            Console.WriteLine("Is {0} divisible without remainder by 5 and 7 at the same time:  {1}", number, Divided);
        }
    }

