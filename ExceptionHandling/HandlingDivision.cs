/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class HandlingDivision
    {
        public static void DivisionInputHandling()
        {
            try
            {
                Console.Write("Enter the number1: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the number1: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine($"Division of {num1} and {num2} is {result}");
            }

            catch (DivideByZeroException ex) {
                Console.WriteLine("Error: "+ ex.Message);
            }

            catch(FormatException ex) {
                Console.WriteLine("Error: " + ex.Message);
            }

            catch(Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void Main()
        {
           
            DivisionInputHandling();
        }
    }
}
*/
