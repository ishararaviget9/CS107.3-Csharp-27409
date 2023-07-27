/*

Modify the same user defined method to method which accept a parameter and 
returns the answer at the end of the method. You should return the calculated Meter 
value at the end of the method. (With return type with parameter method). Display 
the answer by using object.
*/


// 3. Convert kilometers to meters with parameters and return the value

using System;

public class ConvertValues
{
    public int kilometerTOmeter(int km)
    {
        int meter = km * 1000;
        return meter;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the ConvertValues class
        var convertValues = new ConvertValues();

        // Call the kilometerTOmeter method with a parameter value of 10 and store the result in a variable
        int meter = convertValues.kilometerTOmeter(10);

        // Print the result
        Console.WriteLine("The equivalent of 10 kilometer in meter is: " + meter);
    }
}