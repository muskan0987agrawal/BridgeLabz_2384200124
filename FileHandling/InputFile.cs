/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileHandling
{
    internal class InputFile
    {
        public static void Main()
        {
            string name, age, favoriteLanguage;
           try{ using (StreamReader st = new StreamReader(Console.OpenStandardInput()))
            {
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();

                Console.WriteLine("Enter your age:");
                age = Console.ReadLine();

                Console.WriteLine("Enter your favorite programming language:");
                favoriteLanguage = Console.ReadLine();

            }
            string path1 = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\InputText.txt";
            using (StreamWriter writer = new StreamWriter(path1))
            {
                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Age: {age}");
                writer.WriteLine($"Favorite Language: {favoriteLanguage}");
            }
        }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age. Please enter a valid integer.");
            }
             catch (Exception ex)
             {
                Console.WriteLine("An error occurred: " + ex.Message);
               }
            
            finally
            {
                Console.WriteLine("Program execution complete.");
                Console.ReadKey();
            }
        }
    }
}
*/
