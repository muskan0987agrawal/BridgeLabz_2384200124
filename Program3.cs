﻿//using System;
//using System.Diagnostics;
//using System.Text;

//class StringPerformanceComparison
//{
//    static void Main()
//    {
//        int iterations = 100000; // 1 million concatenations
//        string text = "Hello";

//        // Measure String performance
//        MeasureConcatenationTime(iterations, text, "String");

//        // Measure StringBuilder performance
//        MeasureConcatenationTime(iterations, text, "StringBuilder");
//    }

//    // Measures execution time for different string operations
//    static void MeasureConcatenationTime(int iterations, string text, string method)
//    {
//        Stopwatch stopwatch = new Stopwatch();
//        stopwatch.Start();

//        if (method == "String")
//        {
//            ConcatenateUsingString(iterations, text);
//        }
//        else if (method == "StringBuilder")
//        {
//            ConcatenateUsingStringBuilder(iterations, text);
//        }
        

//        stopwatch.Stop();
//        Console.WriteLine($"{method} Concatenation Time: {stopwatch.ElapsedMilliseconds} ms");
//    }

//    // Uses a normal string (O(N²) due to immutable nature)
//    static void ConcatenateUsingString(int iterations, string text)
//    {
//        string result = "";
//        for (int i = 0; i < iterations; i++)
//        {
//            result += text; // Creates new string each time (expensive)
//        }
//    }

//    // Uses StringBuilder (O(N), efficient)
//    static void ConcatenateUsingStringBuilder(int iterations, string text)
//    {
//        StringBuilder sb = new StringBuilder();
//        for (int i = 0; i < iterations; i++)
//        {
//            sb.Append(text); // Modifies existing buffer (efficient)
//        }
//    }

//}
