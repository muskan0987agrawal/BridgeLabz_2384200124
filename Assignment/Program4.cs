//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.VisualBasic; // Required for DateAndTime.Now.Ticks

//namespace _15_02_2025StringBuilderFile
//{
//    internal class Program4
//    {
//        static void Main()
//        {
//            int iterations = 100000; // Number of concatenations

//            // Using DateAndTime.Now.Ticks for String Concatenation
//            long startTicks1 = DateAndTime.Now.Ticks;
//            string str = "";
//            for (int i = 0; i < iterations; i++)
//            {
//                str += "a"; // Concatenation using +=
//            }
//            long endTicks1 = DateAndTime.Now.Ticks;
//            Console.WriteLine($"String concatenation time: {(endTicks1 - startTicks1) / 10000.0} ms");

//            // Using DateAndTime.Now.Ticks for StringBuilder
//            long startTicks2 = DateAndTime.Now.Ticks;
//            StringBuilder sb = new StringBuilder();
//            for (int i = 0; i < iterations; i++)
//            {
//                sb.Append("a"); // Using StringBuilder
//            }
//            long endTicks2 = DateAndTime.Now.Ticks;
//            Console.WriteLine($"StringBuilder time: {(endTicks2 - startTicks2) / 10000.0} ms");

//            Console.WriteLine("StringBuilder is much faster.");
//        }
//    }


//}
