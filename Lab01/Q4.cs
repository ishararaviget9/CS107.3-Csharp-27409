/*Create a console application that can read salary of an employee and tax rate. Then 
show salary after the tax.*/

// Console application to read salary of an employee and tax rate. Then show salary after the tax.

using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the salary and tax rate from the user.
            float salary = float.Parse(Console.ReadLine());
            float taxRate = float.Parse(Console.ReadLine());

            // Calculate the salary after the tax.
            float salaryAfterTax = salary - (salary * taxRate);

            // Print the salary after the tax to the console.
Console.WriteLine("The salary after the tax is {0}.", salaryAfterTax);
        }
    }
}
