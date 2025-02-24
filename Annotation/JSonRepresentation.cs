//using System;
//using System.Text;
//using System.Reflection;

//class JsonConverter
//{
//    public static string ToJson(object obj)
//    {
//        if (obj == null) return "{}"; // Handle null object case

//        Type type = obj.GetType();
//        StringBuilder jsonBuilder = new StringBuilder();
//        jsonBuilder.Append("{");

//        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
//        for (int i = 0; i < fields.Length; i++)
//        {
//            FieldInfo field = fields[i];
//            object value = field.GetValue(obj);

//            // Append field name and value in JSON format
//            jsonBuilder.Append($"\"{field.Name}\": \"{value}\"");

//            // Add comma except for the last element
//            if (i < fields.Length - 1)
//                jsonBuilder.Append(", ");
//        }

//        jsonBuilder.Append("}");
//        return jsonBuilder.ToString();
//    }
//}

//// Sample Class
//class Person
//{
//    private string name = "Muskan";
//    public int age = 25;
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person();

//        // Convert object to JSON-like string
//        string json = JsonConverter.ToJson(person);

//        // Print JSON output
//        Console.WriteLine(json);
//    }
//}
