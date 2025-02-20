/*using System;
using System.IO;
using System.Drawing; // Add this for image manipulation (System.Drawing.Common)
using System.Security.Cryptography; // For MD5 hash comparison

public class ImageToByteArray
{
    public static void Main(string[] args)
    {
        string imagePath = "input_image.jpg"; // Replace with your image path
        string newImagePath = "output_image.jpg";

        try
        {
            // 1. Convert Image to Byte Array
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap image = new Bitmap(imagePath)) // Use Bitmap for image loading
                {
                    image.Save(ms, image.RawFormat); // Save to MemoryStream in original format
                    imageBytes = ms.ToArray();
                }
            }

            // 2. Write Byte Array to New Image File
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                using (Image image = Image.FromStream(ms)) // Create image from byte array
                {
                    image.Save(newImagePath, image.RawFormat);
                }
            }

            // 3. Verify Images (using MD5 hash comparison)
            if (AreImagesIdentical(imagePath, newImagePath))
            {
                Console.WriteLine("Images are identical.");
            }
            else
            {
                Console.WriteLine("Images are different.");
            }

        }
        catch (IOException ex)
        {
            Console.WriteLine("An IO error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.ReadKey();
        }
    }


    // Helper function to compare images using MD5 hash
    static bool AreImagesIdentical(string path1, string path2)
    {
        using (FileStream fs1 = new FileStream(path1, FileMode.Open))
        using (FileStream fs2 = new FileStream(path2, FileMode.Open))
        using (MD5 md5 = MD5.Create())
        {
            byte[] hash1 = md5.ComputeHash(fs1);
            byte[] hash2 = md5.ComputeHash(fs2);

            return StructuralComparisons.StructuralEqualityComparer.Equals(hash1, hash2); // Compare byte arrays
        }
    }
}
*/