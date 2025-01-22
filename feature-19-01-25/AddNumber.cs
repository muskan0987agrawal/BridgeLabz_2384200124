using System;

class AddNumber
{
 static void Main() 
 {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum is: " + (num1 + num2));
		Console.ReadLine();
		}
}
