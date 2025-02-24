//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace ReflectionDemo
//{ 
//    // Custom attribute to mark important methods
//    [AttributeUsage(AttributeTargets.Method)] // Can be applied only to methods
//    internal class ImportantMethodAttribute : Attribute
//    {
//        public string Level { get; } // Importance level of the method

//        // Constructor with an optional parameter, defaulting to "HIGH"
//        public ImportantMethodAttribute(string level = "HIGH")
//        {
//            Level = level;
//        }
//    }
//    internal class TaskProcessor
//    {
//        [ImportantMethod("CRITICAL")] // High-priority method
//        public void ProcessData()
//        {
//            Console.WriteLine("Processing Data...");
//        }

//        [ImportantMethod] // Default Level = "HIGH"
//        public void GenerateReport()
//        {
//            Console.WriteLine("Generating Report...");
//        }

//        public void NormalTask()
//        {
//            Console.WriteLine("This is a normal task.");
//        }
//    }

//    class Program6
//    {
//        static void Main()
//        {
//            Type type = typeof(TaskProcessor); // Get type information of TaskProcessor
//            TaskProcessor processor = new TaskProcessor(); // Create an instance

//            foreach (MethodInfo method in type.GetMethods()) // Loop through all methods
//            {
//                // Check if the method has the ImportantMethod attribute
//                if (method.GetCustomAttribute(typeof(ImportantMethodAttribute)) is ImportantMethodAttribute important)
//                {
//                    Console.WriteLine($"Executing Important Method: {method.Name} - Level: {important.Level}");
//                    method.Invoke(processor, null); // Call the method dynamically
//                }
//            }
//        }
//    }

//}
