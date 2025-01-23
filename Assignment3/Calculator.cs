/* using System;

class Calculator
{
    static void CreateCalculator()
    {
        // Input the first number
        Console.Write("Enter the first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        // Input the second number
        Console.Write("Enter the second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        // Input the operator
        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Perform the calculation based on the operator
        double result;
        switch (op)
        {
            case "+":
                result = first + second;
                Console.WriteLine($"Result: {first} + {second} = {result}");
                break;

            case "-":
                result = first - second;
                Console.WriteLine($"Result: {first} - {second} = {result}");
                break;

            case "*":
                result = first * second;
                Console.WriteLine($"Result: {first} * {second} = {result}");
                break;

            case "/":
                // Handle division by zero
                if (second == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = first / second;
                    Console.WriteLine($"Result: {first} / {second} = {result}");
                }
                break;

            default:
                Console.WriteLine("Invalid operator. Please use one of the following: +, -, *, /");
                break;
        }
    }

    // Main method
    static void Main()
    {
        CreateCalculator(); // Call the calculator method
    }
}
*/