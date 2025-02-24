//using System;
//using System.Reflection;

//class Configuration
//{
//    private static string API_KEY = "DEFAULT_KEY";

//    public static void ShowKey()
//    {
//        Console.WriteLine($"Current API_KEY: {API_KEY}");
//    }
//}

//class ModifyStaticField
//{
//    static void Main()
//    {
//        // Get type of Configuration class
//        Type type = typeof(Configuration);

//        // Access the private static field using Reflection
//        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

//        if (field != null)
//        {
//            // Print the old value
//            Console.WriteLine("Old Value:");
//            Configuration.ShowKey();

//            // Modify the static field value
//            field.SetValue(null, "NEW_SECRET_KEY");

//            // Print the updated value
//            Console.WriteLine("New Value:");
//            Configuration.ShowKey();
//        }
//        else
//        {
//            Console.WriteLine("Field not found!");
//        }
//    }
//}
