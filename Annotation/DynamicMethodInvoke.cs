//using System;
//using System.Reflection;

//class MathOperations
//{
//    public int Add(int a, int b) => a + b;
//    public int Subtract(int a, int b) => a - b;
//    public int Multiply(int a, int b) => a * b;
//}

//class DynamicMethodInvocation
//{
//    static void Main()
//    {
//        // Create an instance of MathOperations
//        MathOperations mathObj = new MathOperations();
//        Type type = typeof(MathOperations);

//        // Take user input for method name
//        Console.Write("Enter method name (Add / Subtract / Multiply): ");
//        string methodName = Console.ReadLine();

//        // Get the method dynamically
//        MethodInfo method = type.GetMethod(methodName);

//        if (method != null)
//        {
//            // Invoke the method dynamically with parameters (10, 5)
//            object result = method.Invoke(mathObj, new object[] { 10, 5 });

//            // Print the result
//            Console.WriteLine($"Result: {result}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid method name!");
//        }
//    }
//}
