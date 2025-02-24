//using System;
//using System.Reflection;

//namespace ReflectionDemo
//{
//    //Define the Custom Attribute
//    [AttributeUsage(AttributeTargets.Method)] // Apply only on the method
//    internal class TaskInfoAttribute: Attribute
//    {
//        public int Priority {  get; }
//        public string AssignedTo { get; }

//        public TaskInfoAttribute(int priority, string assignedTo)
//        {
//            Priority = priority;
//            AssignedTo = assignedTo;
//        }
//    }

//    internal class TaskManager
//    {
//        [TaskInfo(1, "Muskan")] // Applying Custom Attribute
//        public void CompleteTask()
//        {
//            Console.WriteLine("Task Completed!");
//        }
//    }

//    class Program4
//    {
//        static void Main()
//        {
//            Type type = typeof(TaskManager);
//            MethodInfo method = type.GetMethod("CompleteTask");

//            //check Method have a TaskMethodInfo
//            if (method.GetCustomAttribute(typeof(TaskInfoAttribute)) is TaskInfoAttribute taskInfo)
//            {
//                Console.WriteLine($"Priority: {taskInfo.Priority}");
//                Console.WriteLine($"Assigned To: {taskInfo.AssignedTo}");
//            }
//        }
//    }
//}
