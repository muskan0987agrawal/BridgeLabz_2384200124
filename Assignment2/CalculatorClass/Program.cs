// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CalculatorClass;
class Program1
{
   public static void Main()
    {
        Calculator calculator = new Calculator(10, 2);
        Console.WriteLine("Add: " + calculator.Add());
        Console.WriteLine("Subtract: " + calculator.Subtract());
        Console.WriteLine("Multiply: " + calculator.Multiply());
        try
        {
            Console.WriteLine("Divide: " + calculator.Divide());
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.ToString());
        }
        

    }
}
