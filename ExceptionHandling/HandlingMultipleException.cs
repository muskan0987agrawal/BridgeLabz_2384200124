/* using System;
using System.Collections.Generic;


namespace ExceptionHandling
{
    internal class HandlingMultipleException
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter the size of the array: ");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter index to retrieve value:");
                int index = Convert.ToInt32(Console.ReadLine());

                // Retrieve and print value
                Console.WriteLine($"Value at index {index}: {arr[index]}");
            }
           
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Invalid Index");
            }
            catch(NullReferenceException ex)
             {
                    Console.WriteLine("Array is not intialized");
             }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
      
    }
}
*/