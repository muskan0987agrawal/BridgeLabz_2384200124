﻿using System;
using System.IO;

namespace FileHandling
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            // Define source and destination file paths
            string sourceFile = @"input.txt";
            string destinationFile = @"output.txt";

            try
            {
                // Check if the source file exists before proceeding
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Error: Source file does not exist.");
                    return; // Exit the program if the file is missing
                }

                // Open file streams for reading and writing
                using (FileStream readFile = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream writeFile = new FileStream(destinationFile, FileMode.Create, FileAccess.Write)) // Use Create mode to avoid errors if file doesn't exist
                {
                    int data;

                    // Read and write data byte by byte
                    while ((data = readFile.ReadByte()) != -1)
                    {
                        writeFile.WriteByte((byte)data);
                    }

                    Console.WriteLine("File copied successfully.");
                }
            }
            catch (IOException ex)
            {
                // Handle general input/output errors
                Console.WriteLine("IO Exception: " + ex.Message);
            }
        }
    }
}