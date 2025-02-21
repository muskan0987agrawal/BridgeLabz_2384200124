/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class InvalidAgeCustomException : Exception
    {
        public int age { get; set; }
        public InvalidAgeCustomException(string message, int age) : base(message)
        {
            this.age = age;

        }
    }
    internal class CustomException
    {
        static void ValidateAge(int age)
        {

            if (age < 18)
            {
                throw new InvalidAgeCustomException("Age must be 18 or older", age);
            }

        }
        static void Main()
        {
            int age;
            try
            {
                Console.Write("Enter the age: ");
                age = int.Parse(Console.ReadLine());
                try
                {
                    ValidateAge(age);
                }
                catch (InvalidAgeCustomException e)
                {
                    Console.WriteLine("Caught custom exception: " + e.Message + "age is: "+age);
                }


            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
*/