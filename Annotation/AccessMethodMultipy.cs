//using System;
//using System.Reflection;

//class Calculator
//{
//    // Private method
//    private int Multiply(int a, int b)
//    {
//        return a * b;
//    }
//}

//class InvokePrivateMethod
//{
//    static void Main()
//    {
//        // Create an instance of Calculator
//        Calculator calc = new Calculator();
//        Type type = typeof(Calculator);

//        // Get the private method 'Multiply'
//        MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

//        // Invoke the method with arguments (5, 6)
//        object result = method.Invoke(calc, new object[] { 5, 6 });

//        // Print the result
//        Console.WriteLine("Result: " + result);
//    }
//}
