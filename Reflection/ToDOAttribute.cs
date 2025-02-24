//using System;
//using System.Reflection;

//// Define the custom Todo attribute
//[AttributeUsage(AttributeTargets.Method)] // Can be applied only to methods
//internal class TodoAttribute : Attribute
//{
//    public string Task { get; }
//    public string AssignedTo { get; }
//    public string Priority { get; }

//    // Constructor with priority defaulting to "MEDIUM"
//    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
//    {
//        Task = task;
//        AssignedTo = assignedTo;
//        Priority = priority;
//    }
//}

//internal class ProjectManager
//{
//    [Todo("Implement user authentication", "Muskan", "HIGH")]
//    public void UserAuthentication()
//    {
//        Console.WriteLine("User authentication is under development...");
//    }

//    [Todo("Optimize database queries", "John", "LOW")]
//    public void OptimizeDatabase()
//    {
//        Console.WriteLine("Database optimization is in progress...");
//    }

//    [Todo("Design new dashboard UI", "Aisha")] // Default priority = "MEDIUM"
//    public void DesignDashboard()
//    {
//        Console.WriteLine("Dashboard UI design is pending...");
//    }

//    public void CompletedTask()
//    {
//        Console.WriteLine("This task is completed.");
//    }
//}

//class Program7
//{
//    static void Main()
//    {
//        Type type = typeof(ProjectManager); // Get type information of ProjectManager
//        ProjectManager manager = new ProjectManager(); // Create an instance

//        Console.WriteLine("Pending Tasks:");

//        foreach (MethodInfo method in type.GetMethods()) // Loop through all methods
//        {
//            // Check if the method has the Todo attribute
//            if (method.GetCustomAttribute(typeof(TodoAttribute)) is TodoAttribute todo)
//            {
//                Console.WriteLine($"Task: {todo.Task}");
//                Console.WriteLine($"Assigned To: {todo.AssignedTo}");
//                Console.WriteLine($"Priority: {todo.Priority}");
//                Console.WriteLine($"Method: {method.Name}\n");
//            }
//        }
//    }
//}


