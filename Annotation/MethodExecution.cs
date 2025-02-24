//using System;
//using System.Diagnostics;
//using System.Reflection;

//public class SampleClass
//{
//    public void FastMethod()
//    {
//        // Simulate a fast operation
//        Console.WriteLine("Fast method executed.");
//    }

//    public void SlowMethod()
//    {
//        // Simulate a slow operation
//        System.Threading.Thread.Sleep(1000);
//        Console.WriteLine("Slow method executed.");
//    }
//}

//public class MethodExecutionTimer
//{
//    public static void MeasureExecutionTime(object obj, string methodName)
//    {
//        Type type = obj.GetType();
//        MethodInfo method = type.GetMethod(methodName);

//        if (method == null)
//        {
//            Console.WriteLine($"Method {methodName} not found.");
//            return;
//        }

//        Stopwatch stopwatch = Stopwatch.StartNew();
//        method.Invoke(obj, null);
//        stopwatch.Stop();

//        Console.WriteLine($"Execution time of {methodName}: {stopwatch.ElapsedMilliseconds} ms");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SampleClass sample = new SampleClass();

//        // Measure execution time of methods dynamically
//        MethodExecutionTimer.MeasureExecutionTime(sample, "FastMethod");
//        MethodExecutionTimer.MeasureExecutionTime(sample, "SlowMethod");
//    }
//}
