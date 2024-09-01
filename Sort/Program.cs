using System;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortArray = BubbleSort(new int[] {7, 4, 9, 3, 2, 1, 6, 8, 5, 10 });

            Console.WriteLine(string.Join(", ", sortArray));
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
    }
}
