/* using System;
using System.Collections.Generic;
using System.IO;
namespace ExceptionHandling
{
    internal class usingStatementFileHandling
    {
        public static void Main()
        {
          string path = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\InputText.txt";
            try
            {
                using (StreamReader s = new StreamReader(path))
                {
                    string firstLine = s.ReadLine();
                    Console.WriteLine($"First Line: {firstLine}");
                }
                
            }
        
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
}

    }
}
*/
