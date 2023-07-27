/*
Declare two single dimensional array with the size given by the user and find. Display the 
following,
Scalar Sum (Adding values of each element of an array)
Vector Sum (Adding values of each relative elements of an array and store them in third array)
Vector Product (Multiply values of each relative elements of an array and store them in third 
array)
Scalar Product (Multiply values of each relative elements of an array and store them in third 
array. After placing the values in third array add all the values)
*/
using System;

namespace ScalarVectorProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];
            int[] vectorSum = new int[arraySize];
            int[] vectorProduct = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
                array2[i] = int.Parse(Console.ReadLine());
            }

            int scalarSum = ScalarSum(array1);
            vectorSum = VectorSum(array1, array2);
            vectorProduct = VectorProduct(array1, array2);
            int scalarProduct = ScalarProduct(array1, array2);

            Console.WriteLine("Scalar sum of array1 is: " + scalarSum);
            Console.WriteLine("Vector sum of array1 and array2 is: " + string.Join(", ", vectorSum));
            Console.WriteLine("Vector product of array1 and array2 is: " + string.Join(", ", vectorProduct));
            Console.WriteLine("Scalar product of array1 and array2 is: " + scalarProduct);
        }

        private static int ScalarSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        private static int[] VectorSum(int[] array1, int[] array2)
        {
            int[] vectorSum = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                vectorSum[i] = array1[i] + array2[i];
            }
            return vectorSum;
        }

        private static int[] VectorProduct(int[] array1, int[] array2)
        {
            int[] vectorProduct = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                vectorProduct[i] = array1[i] * array2[i];
            }
            return vectorProduct;
        }

        private static int ScalarProduct(int[] array1, int[] array2)
        {
            int scalarProduct = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                scalarProduct += array1[i] * array2[i];
            }
            return scalarProduct;
        }
    }
}