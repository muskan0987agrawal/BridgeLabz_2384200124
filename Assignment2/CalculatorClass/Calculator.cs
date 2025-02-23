using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{ 
public class Calculator
{
     private double a;
     private double b;

    public Calculator(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    public double Add()
    {
        return a + b;
    }

    public double Subtract()
    {
        return a - b;
    }

    public double Multiply()
    {
        return a * b;
    }

    public double Divide()
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return a / b;
    }
}
}