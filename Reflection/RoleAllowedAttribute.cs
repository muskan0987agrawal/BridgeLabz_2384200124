//using System;
//using System.Reflection;

//// Define the RoleAllowed attribute
//[AttributeUsage(AttributeTargets.Method)] // Applied only to methods
//internal class RoleAllowedAttribute : Attribute
//{
//    public string Role { get; }

//    public RoleAllowedAttribute(string role)
//    {
//        Role = role;
//    }
//}

//internal class SecureOperations
//{
//    [RoleAllowed("ADMIN")] // Only ADMINs can call this method
//    public void AdminTask()
//    {
//        Console.WriteLine("Admin Task Executed!");
//    }

//    [RoleAllowed("USER")] // Only USERS can call this method
//    public void UserTask()
//    {
//        Console.WriteLine("User Task Executed!");
//    }

//    public void PublicTask()
//    {
//        Console.WriteLine("Public Task Executed! No role required.");
//    }
//}

//class Program
//{
//    static void ExecuteIfAllowed(object obj, string methodName, string currentUserRole)
//    {
//        Type type = obj.GetType();
//        MethodInfo method = type.GetMethod(methodName);

//        if (method == null)
//        {
//            Console.WriteLine($"Error: Method '{methodName}' not found.");
//            return;
//        }

//        // Check if method has the RoleAllowed attribute
//        if (method.GetCustomAttribute(typeof(RoleAllowedAttribute)) is RoleAllowedAttribute roleAllowed)
//        {
//            if (roleAllowed.Role != currentUserRole)
//            {
//                Console.WriteLine($"Access Denied! '{methodName}' requires '{roleAllowed.Role}' role.");
//                return;
//            }
//        }

//        // If access is allowed, invoke the method
//        method.Invoke(obj, null);
//    }

//    static void Main()
//    {
//        SecureOperations operations = new SecureOperations();

//        string currentUserRole = "USER"; // Change this to "ADMIN" to test access

//        Console.WriteLine("\nTrying to execute 'AdminTask' as USER:");
//        ExecuteIfAllowed(operations, "AdminTask", currentUserRole); //  Access Denied

//        Console.WriteLine("\nTrying to execute 'UserTask' as USER:");
//        ExecuteIfAllowed(operations, "UserTask", currentUserRole); // Allowed

//        Console.WriteLine("\nTrying to execute 'PublicTask' as USER:");
//        ExecuteIfAllowed(operations, "PublicTask", currentUserRole); // Allowed (No role restriction)
//    }
//}
