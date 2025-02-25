////using System;
////using System.Globalization;
////using System.IO;
////using CsvHelper;
////using CsvHelper.Configuration;

////class Program
////{
////    static void Main()
////    {
////string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\CSVDemo.csv";
////var config = new CsvConfiguration(CultureInfo.InvariantCulture)
////{
////HasHeaderRecord = false, // Tells CsvHelper that there's no header
////HeaderValidated = null,  // Disables header validation
////};

////using (var reader = new StreamReader(filePath))
////using (var csv = new CsvReader(reader, config))
////        {
////            var records = csv.GetRecords<NoHeaderPerson>();

////            Console.WriteLine("Reading CSV Data:");
////            foreach (var record in records)
////            {
////                Console.WriteLine($"{record.Name}, {record.Age}, {record.City}");
////            }
////        }
////    }
////}

////// Class without headers (manually mapped)
////public class NoHeaderPerson
////{
////    public string Name { get; set; }
////    public int Age { get; set; }
////    public string City { get; set; }
////}

// using System;
//using System.IO;
//using CsvHelper;
//using System.Globalization;
//using System.Collections.Generic;
//using CsvHelper.Configuration;
////By using Csv Helper
//class ReadCSVUsingCsvHelper
//{
//   static void Main()
//   {
//       string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\CSVDemo.csv";
//       var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//       {
//           HasHeaderRecord = false, // Tells CsvHelper that there's no header
//           HeaderValidated = null,  // Disables header validation
//       };

//       using (var reader = new StreamReader(filePath))
//       using (var csv = new CsvReader(reader, config))
//       {
//           var records = csv.GetRecords<Employee>();
//           foreach (var record in records)
//           {
//               Console.WriteLine($"ID: {record.ID}, Name: {record.Name}");
//           }
//       }
//   }
//}



//public class Employee
//{
//    public string ID { get; set; }
//    public string Name { get; set; }

//}


////using System;
////using System.IO;

////class ReadCSVWithoutCsvHelper
////{
////    static void Main()
////    {
////        string filePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\FileDemo\\CSVDemo.csv";

////        using (var reader = new StreamReader(filePath)) // ✅ Open the file for reading
////        {
////            while (!reader.EndOfStream) // ✅ Read file till end
////            {
////                string line = reader.ReadLine(); // ✅ Read one line at a time
////                string[] values = line.Split(','); // ✅ Split line by comma

////                Console.WriteLine($"ID: {values[0].Trim()}, Name: {values[1].Trim()}");
////            }
////        }
////    }
////}
