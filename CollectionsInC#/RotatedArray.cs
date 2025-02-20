/* using System;
using System.Collections.Generic;


namespace CollectionAssignment
{
    internal class RotatedArray
    {
        public static void ReverseArray<T>(int start, int end, List<T> arr )
        {
            int i = start, j = end-1;
            while (i <= j)
            {
                // Swap elements
                T temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                i++;
                j--;
            }
        }
       public static void RotatedArr2(int[] array)
        {
            //O(n) Time Complexity and Space Complexity
            int k = 8, n = array.Length;
            int[] temp = new int[n];
            int j = 0;
            for (int i = (k % n); i < n; i++)
            {
                temp[j++] = array[i];
            }


            for (int i = 0; i < k % n; i++)
            {
                temp[j++] = array[i];
            }

            for (int l = 0; l < n; l++)
            {
                Console.Write(temp[l] + " ");
            }
        }
    }
    class Program3
    {
        public static void Main()
        {
            List<int> arr = new List<int>() { 1,2,3,4,5 };
            int  n = arr.Count, k = 10;
            RotatedArray.ReverseArray(0, k%n, arr);
            RotatedArray.ReverseArray(k%n, n, arr);
           RotatedArray.ReverseArray(0,n,arr);

            int[] array = { 1, 2, 3, 4, 9, 20, 27 };

            foreach( int i in arr)
            {
                Console.Write(i+" ");
            }
           
        }
    }
}
*/
