using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 5, 6, 3, 7, 2 };
            BubleSort(arr);

        }
        public static void BubleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
            
    }
}
