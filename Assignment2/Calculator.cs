/*using System;

class Calculator
{
    static int addNumber(int a, int b)
    {
        return a + b;
    }
    static int SubNumber(int a, int b)
    {
        return a - b;
    }

    static int ProdNumber(int a, int b)
    {
        return a * b;
    }

    static int DivNumber(int a, int b)
    {
        if (b == 0) return 0;
        return a / b;
    }
	
	static void PerformOperation(){
		Console.Write("enter a number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("enter a second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter  the operand {+,-,*,/}: ");
		char operand = (char)Console.Read();
		switch (operand)
        {
            case '+':
                int add = addNumber(a, b);
                Console.WriteLine($"Add two number is: {add}");
                break;
            case '-':
                int sub = SubNumber(a, b);
                Console.WriteLine($"Subtract two number is: {sub}");
                break;
            case '*':
                int mul = ProdNumber(a, b);
                Console.WriteLine($"Product two number is: {mul}");
                break;
            case '/':
                int div = DivNumber(a, b);
                Console.WriteLine($"division two number is: {div}");
                break;
            default:
                Console.WriteLine("there is no operation of this operand");
                break;
        }
	}
	
    static void Main()
    {
        
        PerformOperation();
    }
    }
	*/