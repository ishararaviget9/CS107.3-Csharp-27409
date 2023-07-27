/*Write a Console Application to calculate area and circumference of a circle for given 
radius*/


using System;

namespace CircleAreaCircumference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the radius of the circle from the user.
            float radius = float.Parse(Console.ReadLine());

            // Calculate the area and circumference of the circle.
            float area = Math.PI * radius * radius;
            float circumference = 2 * Math.PI * radius;

            // Display the results to the user.
            Console.WriteLine("The area of the circle is {0}.", area);
            Console.WriteLine("The circumference of the circle is {0}.", circumference);
        }
    }
}