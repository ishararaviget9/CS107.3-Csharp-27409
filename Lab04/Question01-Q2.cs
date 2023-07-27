/*
Modify the same user defined method to method which accepts a parameter value. 
That parameter value is the user given Km value. (No return type with parameter 
method). Display the answer by using the class object
*/


// 2. Convert kilometers to meters with parameters

using System;

public class ConvertValues
{
    public void kilometerTOmeter(int km)
    {
        int meter = km * 1000;
        Console.WriteLine("The equivalent of {} kilometer in meter is: {}".format(km, meter));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the ConvertValues class
        var convertValues = new ConvertValues();

        // Call the kilometerTOmeter method with a parameter value of 10
        convertValues.kilometerTOmeter(10);
    }
}