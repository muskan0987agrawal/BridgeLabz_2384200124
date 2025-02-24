//using System;
//using System.Collections.Generic;
//using System.Reflection;

//class ObjectMapper
//{
//    // Generic Method to Map Dictionary Values to Object Fields
//    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
//    {
//        // Create an instance of the given class
//        T obj = new T();
//        Type type = typeof(T);

//        foreach (var property in properties)
//        {
//            // Get the field by name (case-sensitive)
//            FieldInfo field = type.GetField(property.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

//            if (field != null && field.FieldType == property.Value.GetType())
//            {
//                // Set the field value dynamically
//                field.SetValue(obj, property.Value);
//            }
//        }

//        return obj;
//    }
//}

//// Sample Class with Fields
//class Person
//{
//    private string name;
//    public int age;

//    public void Display()
//    {
//        Console.WriteLine($"Name: {name}, Age: {age}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Dictionary with field names and values
//        var properties = new Dictionary<string, object>
//        {
//            { "name", "Muskan" },  // Private field
//            { "age", 25 }          // Public field
//        };

//        // Convert Dictionary to Object
//        Person person = ObjectMapper.ToObject<Person>(properties);

//        // Display Updated Values
//        person.Display();
//    }
//}
