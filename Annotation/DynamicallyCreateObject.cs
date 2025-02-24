//using System;

//class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public void Display()
//    {
//        Console.WriteLine($"Student Name: {Name}, Age: {Age}");
//    }
//}

//class DynamicObjectCreation
//{
//    static void Main()
//    {
//        // Get the type of Student class
//        Type type = typeof(Student);

//        // Dynamically create an instance of Student without 'new'
//        object obj = Activator.CreateInstance(type);

//        // Set property values dynamically
//        type.GetProperty("Name").SetValue(obj, "Muskan");
//        type.GetProperty("Age").SetValue(obj, 22);

//        // Call the Display method
//        type.GetMethod("Display").Invoke(obj, null);
//    }
//}
