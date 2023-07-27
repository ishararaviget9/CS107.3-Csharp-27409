/*
Declare a Single dimensional array with 10 elements. Input the values to the array and find 
the followings,
• Minimum value.
• Maximum value.
• Average value.
• Reverse order of values.
Hint – use a method which in separate class. And call the method from main the method.

*/
using System;

namespace ArrayOperations
{
    class ArrayOperations
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int minValue = FindMinimumValue(array);
            int maxValue = FindMaximumValue(array);
            float averageValue = FindAverageValue(array);
            int[] reversedArray = ReverseArray(array);

            Console.WriteLine("Minimum value: " + minValue);
            Console.WriteLine("Maximum value: " + maxValue);
            Console.WriteLine("Average value: " + averageValue);
            Console.WriteLine("Reversed array: " + string.Join(", ", reversedArray));
        }

        private static int FindMinimumValue(int[] array)
        {
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }

        private static int FindMaximumValue(int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        private static float FindAverageValue(int[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        private static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[array.Length - 1 - i] = array[i];
            }
            return reversedArray;
        }
    }
}