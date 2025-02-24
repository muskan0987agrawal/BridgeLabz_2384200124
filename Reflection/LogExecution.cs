//using System;
//using System.Diagnostics;
//using System.Reflection;

//// Define the custom LogExecutionTime attribute
//[AttributeUsage(AttributeTargets.Method)] // Apply only to methods
//internal class LogExecutionTimeAttribute : Attribute
//{
//}

//internal class TaskProcessor
//{
//    [LogExecutionTime]
//    public void QuickTask()
//    {
//        Console.WriteLine("Executing Quick Task...");
//        System.Threading.Thread.Sleep(500); // Simulate a quick task (500ms)
//    }

//    [LogExecutionTime]
//    public void LongTask()
//    {
//        Console.WriteLine("Executing Long Task...");
//        System.Threading.Thread.Sleep(2000); // Simulate a long task (2000ms)
//    }

//    public void NormalMethod()
//    {
//        Console.WriteLine("This is a normal method without logging.");
//    }
//}

//class Program8
//{
//    static void Main()
//    {
//        Type type = typeof(TaskProcessor);
//        TaskProcessor processor = new TaskProcessor();

//        Console.WriteLine("Logging Method Execution Time:\n");

//        foreach (MethodInfo method in type.GetMethods()) // Loop through all methods
//        {
//            if (method.GetCustomAttribute(typeof(LogExecutionTimeAttribute)) is LogExecutionTimeAttribute)
//            {
//                Stopwatch stopwatch = Stopwatch.StartNew(); // Start measuring time

//                method.Invoke(processor, null); // Invoke the method dynamically

//                stopwatch.Stop(); // Stop measuring time
//                Console.WriteLine($"Execution Time for {method.Name}: {stopwatch.ElapsedMilliseconds} ms\n");
//            }
//        }
//    }
//}
