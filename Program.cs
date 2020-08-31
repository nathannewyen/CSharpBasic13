using System;
using System.Collections.Generic;
namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();

            PrintOdds();

            PrintSum();

            LoopArray(1, 2, 3, 4, 5, 6, 7, 8, 9);

            Console.WriteLine(FindMax(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 22, 11));

            GetAverage(2, 10, 3);

            // OddArray();

            GtY(6, 1, 5, 5, 7);

            SquareArrayValues(1, 2, 3, 4, 5, 6, 7, 8, 9);

            EliminateNegatives(1, 2, 5, 10, -2);

            MinMaxAverage(1, 5, 10, -2);

            ShiftValues(new List<int> { 1, 5, 10, 7, -2 });

            NumToString(new List<object> { -1, -3, 2 });

        }

        public static void PrintNumbers()
        {
            // // Print all of the integers from 1 to 255.
            // for (int i = 1; i <= 255; i++) {
            //     Console.WriteLine (i);
            // }
        }

        public static void PrintOdds()
        {
            // // Print odd numbers between 1-255
            // for (int i = 1; i <= 255; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
        }

        public static void PrintSum()
        {
            // // Print Sum
            // int sum = 0;
            // for (int i = 0; i <= 255; i++)
            // {
            //     sum += i;

            // }
        }

        // Iterating through an Array
        public static void LoopArray(params int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        // Find Max
        public static int FindMax(params int[] numbers)
        {
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        // Get Average
        public static void GetAverage(params int[] numbers)
        {
            int avg = 0, sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            avg = sum / numbers.Length;
            Console.WriteLine(avg);
        }

        // Array with Odd Numbers
        public static int[] OddArray()
        {
            var newArray = new List<int>();
            for (int i = 1; i <= 256; i++)
            {
                if (i % 2 == 1)
                {
                    newArray.Add(i);
                }
            }
            Console.WriteLine("newArray: " + newArray);
            foreach (int i in newArray)
            {
                Console.WriteLine(i);
            }
            return null;
        }

        // Greater than Y
        public static void GtY(int y, params int[] numbers)
        {
            int count = 0;
            foreach (int i in numbers)
            {
                if (i > y)
                {
                    count++;
                }
                Console.WriteLine($"Num on Ints greater than {y}: {count}");
            }
        }

        // Square the Values

        public static void SquareArrayValues(params int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            var newArray = new List<int>();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        // Eliminate Negative Numbers
        public static void EliminateNegatives(params int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            foreach (int i in numbers)
            {
                Console.Write(i + ", ");
            }
        }

        // Min, Max, and Average
        public static void MinMaxAverage(params int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int sum = 0, max = numbers[0], min = numbers[0], avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("Min: " + min + " Max: " + max + " Avg: " + avg);
        }

        // Shifting the values in an array
        public static void ShiftValues(List<int> shifties)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].

            shifties.RemoveAt(0);
            shifties.Add(0);
            Console.Write("[ ");
            foreach (int shifty in shifties)
            {
                Console.Write(shifty + ", ");
            }
            Console.WriteLine("]");
        }

        // Number to String
        public static object[] NumToString(List<object> numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            for (int i = 0; i < numbers.Count; i++)
            {
                if ((int)numbers[i] < 0)
                {
                    numbers[i] = "Dojo";
                }
            }
            foreach (var item in numbers)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            return null;
        }

    }
}