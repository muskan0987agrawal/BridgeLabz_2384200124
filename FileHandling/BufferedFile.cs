/* using System;
using System.Diagnostics;
using System.IO;

namespace FileHandling
{
    internal class ReadWriteFile
    {
        public static void CopyFile(string source, string destination)
        {
            if (!File.Exists(source))
            {
                Console.WriteLine("File doesn't exist");
                return;
            }
            try
            {
                using (FileStream fsRRead = new FileStream(source, FileMode.Open, FileAccess.Read))
                using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
                {
                    int byteData;
                    while ((byteData = fsRRead.ReadByte()) != -1)
                    {
                        fsWrite.WriteByte((byte)byteData);
                    }
                    Console.WriteLine("File Copied successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CopyFileWithBufferedStream(string source, string destination)
        {
            if (!File.Exists(source))
            {
                Console.WriteLine("File doesn't exist");
                return;
            }
            try
            {
                using (FileStream fsRRead = new FileStream(source, FileMode.Open, FileAccess.Read))
                using (BufferedStream bufferedRead = new BufferedStream(fsRRead, 4096)) // 4 KB buffer
                using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
                using (BufferedStream bufferedWrite = new BufferedStream(fsWrite, 4096)) // 4 KB buffer
                {
                    byte[] buffer = new byte[4096]; // 4 KB buffer
                    int bytesRead;
                    while ((bytesRead = bufferedRead.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bufferedWrite.Write(buffer, 0, bytesRead);
                    }
                    Console.WriteLine("File Copied successfully with BufferedStream");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main()
        {
            string path1 = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\LargeFile.bin"; // Large file (e.g., 100MB)
            string path2 = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\WriteText_Unbuffered.bin";
            string path3 = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\WriteText_Buffered.bin";

            // Measure time for unbuffered file copy
            Stopwatch unbufferedStopwatch = new Stopwatch();
            unbufferedStopwatch.Start();
            CopyFile(path1, path2);
            unbufferedStopwatch.Stop();
            Console.WriteLine($"Time taken for unbuffered copy: {unbufferedStopwatch.ElapsedMilliseconds} ms");

            // Measure time for buffered file copy
            Stopwatch bufferedStopwatch = new Stopwatch();
            bufferedStopwatch.Start();
            CopyFileWithBufferedStream(path1, path3);
            bufferedStopwatch.Stop();
            Console.WriteLine($"Time taken for buffered copy: {bufferedStopwatch.ElapsedMilliseconds} ms");
        }
    }
}
*/