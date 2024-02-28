//Name : Ankita Singh
//Date : 02/28/2024
//Type of Sort : Bubble Sorting


using System;

class Program
{
    static void Main(string[] args)
    {
        // Input array
        int[] arr = { 5, 72, 3, 14, 7, 1 };

        // Sort the array using Bubble Sort
        BubbleSort(arr);

        // Print the sorted array
        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }

    // Method to perform Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        // Outer loop for the number of passes
        for (int i = 0; i < n - 1; i++)
        {
            // Inner loop for comparisons and swaps
            for (int j = 0; j < n - i - 1; j++)
            {
                // Compare adjacent elements and swap if necessary
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Method to print the elements of an array
    static void PrintArray(int[] arr)
    {
        // Iterate through the array and print each element
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine(); // Move to the next line after printing all elements
    }
}
