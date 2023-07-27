/*
Create a Console application with two classes (Main class + another class). Inside the main 
class take a user input which is the size of the array. Pass the user inserted size as a parameter 
to the added class method. Inside the method create an integer array based on passed value 
from main method. Then take user inputs for the created array inside the separate class. 
Every user input value should be followed by value 0 inside the array.
Eg. Assume array size is 9 and it should as follows.
Now print all the values inside the array.
*/
using System;

namespace ArrayInput
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());

            ArrayInputClass arrayInputClass = new ArrayInputClass(arraySize);
            arrayInputClass.InputArray();
            arrayInputClass.PrintArray();
        }
    }

    class ArrayInputClass
    {
        private int[] array;

        public ArrayInputClass(int arraySize)
        {
            this.array = new int[arraySize];
        }

        public void InputArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                array[i] = input;
                array[i + 1] = 0;
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}