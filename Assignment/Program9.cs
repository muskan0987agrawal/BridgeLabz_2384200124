/* using System;

namespace SchoolSystem
{
    // Base Class: Person
    internal class Person
    {
        protected string Name;
        protected int Age;

        public void SetPersonDetails(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} \nAge: {Age}");
        }
    }

    // Subclass: Teacher
    internal class Teacher : Person
    {
        private string Subject;

        public void SetTeacherDetails(string name, int age, string subject)
        {
            SetPersonDetails(name, age);
            this.Subject = subject;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Teacher \nSubject: {Subject}");
        }
    }

    // Subclass: Student
    internal class Student : Person
    {
        private string Grade;

        public void SetStudentDetails(string name, int age, string grade)
        {
            SetPersonDetails(name, age);
            this.Grade = grade;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Student \nGrade: {Grade}");
        }
    }

    // Subclass: Staff
    internal class Staff : Person
    {
        private string Department;

        public void SetStaffDetails(string name, int age, string department)
        {
            SetPersonDetails(name, age);
            this.Department = department;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Staff \nDepartment: {Department}");
        }
    }

    // Main Program
    internal class Program9
    {
        public static void Main()
        {
            // Creating different roles
            Teacher teacher = new Teacher();
            teacher.SetTeacherDetails("Mr. Agrawal", 40, "Mathematics");

            Student student = new Student();
            student.SetStudentDetails("Aarav", 16, "10th Grade");

            Staff staff = new Staff();
            staff.SetStaffDetails("Mr. XYZ", 35, "Administration");

            // Array for polymorphism
            Person[] people = { teacher, student, staff };

            // While loop for user interaction
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. View Teacher Details");
                Console.WriteLine("2. View Student Details");
                Console.WriteLine("3. View Staff Details");
                Console.WriteLine("4. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                if (choice >= 1 && choice <= 3)
                {
                    Console.WriteLine("\nDetails:");
                    people[choice - 1].DisplayInfo();
                    Console.WriteLine("----------------------");
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please try again.");
                }
            }
        }
    }
}
*/
