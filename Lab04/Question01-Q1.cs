/*Create a C# Console application to convert user given Kilo Meter (km) Value to Meter 
(m) value. Take a separate Class call “ConvertValues” and inside the class create a 
method call kilometerTOmeter. (No return type No Parameter Method). And display 
the answer within the method. Then create an object in main Class (program class) 
and call the method.
*/


// 1. Convert kilometers to meters without parameters

using System;

public class ConvertValues
{
    public void kilometerTOmeter()
    {
        int km = 1000;
        int meter = km * 1000;
        Console.WriteLine("The equivalent of 1 kilometer in meter is: " + meter);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the ConvertValues class
        var convertValues = new ConvertValues();

        // Call the kilometerTOmeter method
        convertValues.kilometerTOmeter();
    }
}