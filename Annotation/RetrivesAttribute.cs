//using System;
//using System.Reflection;

//// Define the Custom Attribute
//[AttributeUsage(AttributeTargets.Class)] // Can only be applied to classes
//class AuthorAttribute : Attribute
//{
//    public string Name { get; }

//    public AuthorAttribute(string name)
//    {
//        Name = name;
//    }
//}

//// Apply the Custom Attribute to a Class
//[Author("Muskan")]
//class SampleClass
//{
//    public void Display()
//    {
//        Console.WriteLine("SampleClass Method Executed!");
//    }
//}

//class RetrieveAttributeRuntime
//{
//    static void Main()
//    {
//        // Get type of SampleClass
//        Type type = typeof(SampleClass);

//        // Check if the Author attribute is applied
//        if (type.GetCustomAttribute(typeof(AuthorAttribute)) is AuthorAttribute author)
//        {
//            // Print the author name
//            Console.WriteLine($"Author: {author.Name}");
//        }
//        else
//        {
//            Console.WriteLine("No Author attribute found.");
//        }
//    }
//}
