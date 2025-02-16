/*using System;

class Program
{
    static int FindMissing(int[] nums)
    {
        int n = nums.Length;

        // Replace invalid numbers with n+1
        for (int i = 0; i < n; i++)
        {
            if (nums[i] <= 0 || nums[i] > n)
                nums[i] = n + 1;  
        }

        // Mark existing numbers by making them negative
        for (int i = 0; i < n; i++)
        {
            int val = Math.Abs(nums[i]);  
            if (val <= n)
                nums[val - 1] = -Math.Abs(nums[val - 1]);  // Mark the index
        }

        // Step 3: First positive index is our answer
        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0)
                return i + 1;  
        }

        return n + 1;  
    }

    static void Main()
    {
        int[] arr = { 3, 4, -1, 1 };
        Console.WriteLine("First Missing Positive: " + FindMissing(arr));
    }
}
*/