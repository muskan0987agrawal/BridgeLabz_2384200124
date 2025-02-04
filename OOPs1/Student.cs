//using System;

//namespace OOPs1
//{
//    internal class Student
//    {
//        private static string UniversityName = "GLA University"; // Shared among all students
//        private static int totalStudents = 0; // Count of total students

//        public readonly int rollNumber; // Readonly: cannot be changed
//        public string name;
//        public string grade;

//        // Constructor using 'this'
//        public Student(int rollNumber, string name, string grade)
//        {
//            this.rollNumber = rollNumber;
//            this.name = name;
//            this.grade = grade;
//            totalStudents++;
//        }

//        // Static method to display total students
//        public static void DisplayTotalStudents()
//        {
//            Console.WriteLine($"\nTotal Students Enrolled: {totalStudents}");
//        }

//        // Display student details
//        public void DisplayStudent()
//        {
//            Console.WriteLine($"\nRoll Number: {rollNumber}");
//            Console.WriteLine($"Name: {name}");
//            Console.WriteLine($"Grade: {grade}");
//            Console.WriteLine($"University: {UniversityName}");
//            Console.WriteLine($"----------------------------");
//        }

//        // Method to check if an object is a Student
//        public static void CheckInstance(object obj)
//        {
//            if (obj is Student)
//            {
//                Console.WriteLine("This is a valid Student instance.");
//            }
//            else
//            {
//                Console.WriteLine("This is NOT a Student instance.");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Enter the number of students: ");
//            int numStudents = int.Parse(Console.ReadLine());

//            Student[] students = new Student[numStudents]; // Fixed-size array

//            // Taking input from the user
//            for (int i = 0; i < numStudents; i++)
//            {
//                Console.WriteLine($"\nEnter details for Student {i + 1}");
//                Console.Write("Roll Number: ");
//                int rollNumber = int.Parse(Console.ReadLine());

//                Console.Write("Name: ");
//                string name = Console.ReadLine();

//                Console.Write("Grade: ");
//                string grade = Console.ReadLine();

//                students[i] = new Student(rollNumber, name, grade);
//            }

//            // Display all students
//            Console.WriteLine("\n=== University Students Details ===");
//            for (int i = 0; i < numStudents; i++)
//            {
//                if (students[i] is Student)
//                {
//                    students[i].DisplayStudent();
//                }
//            }

//            // Display total students enrolled
//            Student.DisplayTotalStudents();
//        }
//    }
//}