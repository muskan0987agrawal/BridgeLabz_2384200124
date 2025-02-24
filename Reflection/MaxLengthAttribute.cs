//using System;
//using System.Reflection;

//// Define the MaxLength attribute
//[AttributeUsage(AttributeTargets.Property)] // Can be applied only to properties
//internal class MaxLengthAttribute : Attribute
//{
//    public int Length { get; }

//    public MaxLengthAttribute(int length)
//    {
//        Length = length;
//    }
//}

//internal class User
//{
//    [MaxLength(10)] // Username must be at most 10 characters long
//    public string Username { get; set; }

//    public User(string username)
//    {
//        ValidateMaxLength(this, username);
//        Username = username;
//    }

//    private void ValidateMaxLength(object obj, string value)
//    {
//        Type type = obj.GetType();
//        PropertyInfo property = type.GetProperty("Username");

//        if (property != null && property.GetCustomAttribute(typeof(MaxLengthAttribute)) is MaxLengthAttribute maxLength)
//        {
//            if (value.Length > maxLength.Length)
//            {
//                throw new ArgumentException($"Error: Username exceeds the maximum length of {maxLength.Length} characters.");
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            User user1 = new User("Muskan"); // Valid username
//            Console.WriteLine($"User created: {user1.Username}");

//            User user2 = new User("VeryLongUsername"); // Exceeds max length, throws exception
//            Console.WriteLine($"User created: {user2.Username}");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}
