/* using System;
using System.Collections.Generic;


namespace _18_02_2024
{
    abstract class CourseType
    {
        public string CourseName { get; set; }
        public string EvaluationType { get; set; }
        public abstract void DisplayDetails();
    }

    class ExamCourse: CourseType
    {
        public string ExamDate { get; set; }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Course: {CourseName}, Evaluation: {EvaluationType}, Exam Date: {ExamDate}");
        }
    }
    
    class AssignmentType: CourseType
    {
        public string SubmissionDeadline { get; set; }

        // Implementing abstract method to display assignment course details
        public override void DisplayDetails()
        {
            Console.WriteLine($"Course: {CourseName}, Evaluation: {EvaluationType}, Submission Deadline: {SubmissionDeadline}");
        }
    }

    class Course<T> where T : CourseType {
        List<T> list = new List<T>();
        public void AddCourse(T Course)
        {
            list.Add( Course);
        }

        public void ShowCourseDetails()
        {
            foreach(var Course in list)
            {
                Course.DisplayDetails();
            }
        }
    }

    internal class UniversityCourseManagment
    {
        public static void Main()
        {
            // Create specific courses
            ExamCourse examCourse1 = new ExamCourse
            {
                CourseName = "C-Sharp",
                EvaluationType = "Exam",
                ExamDate = "2025-02-19"
            };

            AssignmentType assignmentCourse1 = new AssignmentType
            {
                CourseName = "Java",
                EvaluationType = "Assignment",
                SubmissionDeadline = "2025-03-20"
            };

            // Create the generic Course management system
            Course<CourseType> courseManagement = new Course<CourseType>();

            // Add courses to the management system
            courseManagement.AddCourse(examCourse1);
            courseManagement.AddCourse(assignmentCourse1);

            // Display all courses
            Console.WriteLine("University Course Catalog:\n");
            courseManagement.ShowCourseDetails();
        }
    }
}
*/