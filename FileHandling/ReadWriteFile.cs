/* using System;
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
                    Console.WriteLine("File Copied suucessfully");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main()

        {
            string path1 = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\InputText.txt";
            string path2 = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\WriteText.txt";
          
            CopyFile(path1, path2);


    }
    } 
}*/

