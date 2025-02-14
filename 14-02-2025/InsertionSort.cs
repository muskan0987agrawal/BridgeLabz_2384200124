/* using System;


namespace _14_02_2025
{
    internal class InsertionSort
    {
        // Function to take user input
        public static int[] TakeInput()
        {
            Console.Write("Enter the size of Employee: ");
           int  n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine($"Enter the Employee ID:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Employe ID {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public static void SortEmployeeID( int[] arr)
        {
           
            int temp;
            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                int j=i;
                while(j>0 && arr[j-1] > temp)
                {

                    arr[j] = arr[j-1];
                    j--;
                }
                arr[j] = temp;
            }
            Console.WriteLine("After Sorted array is: ");
            PrintArr(arr);
        }
        // Function to print an array
        public static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Main()
        {
            int[] arr = TakeInput();
            Console.WriteLine("Unsorted array is: ");
            PrintArr(arr);
            SortEmployeeID(arr);
        }
    }
}
*/