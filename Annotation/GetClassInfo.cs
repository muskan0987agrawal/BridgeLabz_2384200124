//using System;
//using System.Reflection;

//class GetClassInfo
//{
//    static void Main()
//    {
//        Console.Write("Enter class name (e.g., System.String): ");
//        string className = Console.ReadLine(); // Take class name input

//        Type type = Type.GetType(className); // Get Type of the class

//        if (type == null)
//        {
//            Console.WriteLine("Class not found! Check the name and namespace.");
//            return;
//        }

//        Console.WriteLine($"\nClass: {type.FullName}");

//        // Get and display constructors
//        Console.WriteLine("\nConstructors:");
//        foreach (var constructor in type.GetConstructors())
//        {
//            Console.WriteLine(constructor);
//        }

//        // Get and display fields
//        Console.WriteLine("\nFields:");
//        foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
//        {
//            Console.WriteLine(field.Name);
//        }

//        // Get and display methods
//        Console.WriteLine("\nMethods:");
//        foreach (var method in type.GetMethods())
//        {
//            Console.WriteLine(method.Name);
//        }
//    }
//}
