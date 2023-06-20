﻿using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1:

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if(a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            //Exercise 2: see AreaOfCircles Method

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Method1.AreaOfCircle(radius);
        }
    }
}
