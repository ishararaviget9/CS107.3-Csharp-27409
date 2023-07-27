/*
1) Create a C# Console application to find the area and the circumference of a circle.
2) User should insert the radius value to the program. Program should contain a 
separate class call “FindValues” inside the separate class add two methods call 
findArea and findCircumference Both these methods are methods which takes 
parameters. As the parameter you should pass the radius value. By using above 
two methods find the area and circumference of the circle and return the answer 
from both methods. Create a class object in main class and call both methods and 
display the answers.
*/


using System;

public class FindValues
{
    public double findArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return area;
    }

    public double findCircumference(double radius)
    {
        double circumference = 2 * Math.PI * radius;
        return circumference;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a class object
        var findValues = new FindValues();

        // Get the radius from the user
        Console.WriteLine("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        // Find the area and circumference of the circle
        double area = findValues.findArea(radius);
        double circumference = findValues.findCircumference(radius);

        // Display the results
        Console.WriteLine("The area of the circle is: " + area);
        Console.WriteLine("The circumference of the circle is: " + circumference);
    }
}