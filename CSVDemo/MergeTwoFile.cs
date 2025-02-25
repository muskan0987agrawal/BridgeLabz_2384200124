//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CsvHelper;
//using CsvHelper.Configuration;

//namespace CSVDemo
//{
//    internal class MergeTwoFile
//    {
//        static void Main()
//        {
//            string filePath1 = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\Student.csv";
//            string filePath2 = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\Student2.csv";
//            string outputFilePath = "C:\\Users\\Himan\\OneDrive\\Desktop\\C# Programming\\Assignment\\CSVDemo\\CSVDemo\\merged_students.csv";

//            try
//            {
//                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true };
//                // Read students1.csv (ID, Name, Age)
//                List<Student1> students1;

//                using (var reader = new StreamReader(filePath1))
//                {
//                    using (var csv = new CsvReader(reader, config))
//                    {
//                        students1 = new List<Student1>(csv.GetRecords<Student1>());
//                    }
//                }

//                // Read students2.csv (ID, Maeks, Grade)
//                List<Student2> students2;

//                using (var reader = new StreamReader(filePath2))
//                {
//                    using (var csv = new CsvReader(reader, config))
//                    {
//                        students2 = new List<Student2>(csv.GetRecords<Student2>());
//                    }
//                }

//                // Merge files using a simple loop
//                List<MergedStudent> mergedStudents = new List<MergedStudent>();
//                foreach (var s1 in students1)
//                {
//                    foreach (var s2 in students2)
//                    {
//                        if(s1.Id == s2.Id)
//                        {
//                            mergedStudents.Add(new MergedStudent
//                            {
//                                Id = s1.Id,
//                                Name = s1.Name,
//                                Age = s1.Age,
//                                Marks = s2.Marks,
//                                Grade = s2.Grade
//                            });
//                        }
//                    }

//                }
//                // Write merged data to a new CSV file
//                using (var writer = new StreamWriter(outputFilePath))
//                using (var csv = new CsvWriter(writer, config))
//                {
//                    csv.WriteRecords(mergedStudents);
//                }

//                Console.WriteLine("CSV files merged successfully!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//    public class Student1
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }

//    public class Student2
//    {
//        public int Id { get; set; }
//        public int Marks { get; set; }
//        public string Grade { get; set; }
//    }

//    public class MergedStudent
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public int Marks { get; set; }
//        public string Grade { get; set; }
//    }
//}
