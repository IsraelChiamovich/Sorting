using System;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bubbleSortArray = BubbleSort(new int[] {7, 4, 9, 3, 2, 1, 6, 8, 5, 10 });

            Console.WriteLine(string.Join(", ", bubbleSortArray));


            int[] selectionSortArray = BubbleSort(new int[] { 7, 4, 9, 3, 2, 1, 6, 8, 5, 10 });

            Console.WriteLine(string.Join(", ", selectionSortArray));
        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                    
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}
