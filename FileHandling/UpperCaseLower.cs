﻿/*using System;
using System.IO;
using System.Text;

class FilterStreamExample
{
    static void Main()
    {
        string inputFile = "input.txt";    // Original file
        string outputFile = "output.txt";  // Converted file

        try
        {
            ConvertUppercaseToLowercase(inputFile, outputFile);
            Console.WriteLine("File processing complete. Check 'output.txt'.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
    }

    static void ConvertUppercaseToLowercase(string inputPath, string outputPath)
    {
        // Use UTF-8 encoding to handle character encoding issues
        Encoding encoding = Encoding.UTF8;

        using (FileStream inputStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
        using (BufferedStream bufferedInput = new BufferedStream(inputStream))
        using (StreamReader reader = new StreamReader(bufferedInput, encoding))
        using (FileStream outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedOutput = new BufferedStream(outputStream))
        using (StreamWriter writer = new StreamWriter(bufferedOutput, encoding))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());  // Convert to lowercase
            }
        }
    }
}
*/