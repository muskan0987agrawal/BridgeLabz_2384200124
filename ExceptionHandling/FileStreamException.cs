/*using System;
using System.IO;

namespace ExceptionHandling
{
    internal class FileStreamException
    {
        public  void FileException(string FilePath)
        {
            
            try
            {
                    //ReadAllLines Method returns a string array
                    string[] lines = File.ReadAllLines(FilePath);

                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                    }
                
            }
            catch (IOException) // Handling file-related exceptions
            {
                Console.WriteLine("File not found");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: ");
            }

        }
    }

    class Program1
    {
        static void Main()
        {
            string path = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\File.tt";
            FileStreamException f = new FileStreamException();
            f.FileException(path);
        }
    }
}
*/
