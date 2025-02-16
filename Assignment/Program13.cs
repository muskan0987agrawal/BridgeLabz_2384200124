//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = {
//            { 1,  4,  7, 11 },
//            { 2,  5,  8, 12 },
//            { 3,  6,  9, 16 },
//            {10, 13, 14, 17 }
//        };

//        Console.Write("Enter target value to search: ");
//        int target = int.Parse(Console.ReadLine());

//        var result = SearchMatrix(matrix, target);

//        if (result.Item1 != -1)
//            Console.WriteLine($"Target {target} found at row {result.Item1}, column {result.Item2}");
//        else
//            Console.WriteLine("Target not found in the matrix.");
//    }

//    static (int, int) SearchMatrix(int[,] matrix, int target)
//    {
//        int rows = matrix.Length;
//        int cols = matrix[0].Length;
//        int left = 0, right = rows * cols - 1;

//        while (left <= right)
//        {
//            int mid = left + (right - left) / 2;
//            int row = mid / cols;
//            int col = mid % cols;
//            int midValue = matrix[row, col]; // Corrected access for [,] array

//            if (midValue == target)
//                return (row, col); // Target found at (row, col)

//            if (midValue < target)
//                left = mid + 1; // Move right
//            else
//                right = mid - 1; // Move left
//        }

//        return (-1, -1); // Target not found
//    }
//}
