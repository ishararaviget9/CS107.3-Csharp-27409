/*Create a Console application that can read the radius from the user and calculate the 
Area of a circle.*/

// Console application to read the radius from the user and calculate the Area of a circle.

using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the radius from the user.
            float radius = float.Parse(Console.ReadLine());

            // Calculate the area of the circle.
            float area = Math.PI * radius * radius;

            // Print the area to the console.
            Console.WriteLine("The area of the circle is {0}.", area);
        }
    }
}
