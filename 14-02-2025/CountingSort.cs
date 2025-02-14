/*using System;


namespace _14_02_2025
{
    internal class CountingSort
    {
        // Function to take user input
        public static int[] TakeInput()
        {
            Console.Write("Enter the size of Student: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine($"Enter the age of Student [10- 18]:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Age of Student {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        public static void SortAge(int[] age)
        {

            // Define the range of ages (10 to 18)
            int minAge = 10, maxAge = 18;
            int range = maxAge - minAge + 1;


            // Create and initialize counting array
            int[] countArr = new int[range];

            // Count occurrences
            foreach (int ages in age)
            {
                countArr[ages - minAge]++; // Shift index to fit in range 0 to 8
            }

            for (int i = 0; i < countArr.Length; i++) 
            {
                while (countArr[i] > 0)
                {
                    Console.Write( (i+minAge)+ " ");
                    countArr[i]--;
                }
            }
           
         }
        public static void Main()
        {
            int [] arrAge = TakeInput();
            SortAge(arrAge);
        }
    }
}*/
