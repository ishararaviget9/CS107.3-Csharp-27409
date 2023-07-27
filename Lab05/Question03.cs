/*

Create the above mentioned console application and display it to the user. If user need to do 
an Addition user need to insert 1 as the choice. For subtraction it should be 2 etc.
Your program should contain a separate class call “CalculateValues” and inside the class you 
should add four methods which perform four arithmetic operations. All the methods should 
take two parameters which are user inserted numbers.
And at the end of the method return the answer out of the method.
In main class if user want to do an addition call only the addition method in separate class.
If user want to do a subtraction call only the subtraction method in separate class. ETC.
And display the final answer as shown in the figure 01.
*/

using System;

namespace ArithmeticOperations
{
    class CalculateValues
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            int choice;
            int num1, num2;

            Console.WriteLine("Select the operation you want to perform:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter two numbers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            CalculateValues calculateValues = new CalculateValues();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, calculateValues.Addition(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("The difference of {0} and {1} is {2}", num1, num2, calculateValues.Subtraction(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("The product of {0} and {1} is {2}", num1, num2, calculateValues.Multiplication(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("The quotient of {0} and {1} is {2}", num1, num2, calculateValues.Division(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
