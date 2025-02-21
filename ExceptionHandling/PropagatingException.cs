/* using System;

namespace ExceptionHandling
{
    internal class PropagatingException
    {
        // Method that performs division and throws an exception
        static void Method1()
        {
            int a = 10;
            int b = 0;
            int divide = a / b; // This will throw DivideByZeroException
        }

        // Method that calls Method1()
        static void Method2()
        {
            Method1(); // Exception propagates from Method1()
        }

        // Main method where exception is handled
        public static void Main()
        {
            try
            {
                Method2(); // Calls Method2(), which calls Method1()
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught in Main: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception caught: " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("Handled exception in Main.");
            }
        }
    }
}
*/