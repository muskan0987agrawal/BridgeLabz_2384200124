/*using System;

namespace CourseHierarchy
{
    // Base Class: Course
    internal class Course
    {
        protected string CourseName;
        protected int Duration; // in weeks

        public void SetCourseDetails(string courseName, int duration)
        {
            this.CourseName = courseName;
            this.Duration = duration;
        }

        public virtual void DisplayCourseInfo()
        {
            Console.WriteLine($"Course: {CourseName} \nDuration: {Duration} weeks");
        }
    }

    // Subclass: OnlineCourse
    internal class OnlineCourse : Course
    {
        protected string Platform;
        protected bool IsRecorded;

        public void SetOnlineCourseDetails(string courseName, int duration, string platform, bool isRecorded)
        {
            SetCourseDetails(courseName, duration);
            this.Platform = platform;
            this.IsRecorded = isRecorded;
        }

        public override void DisplayCourseInfo()
        {
            base.DisplayCourseInfo();
            Console.WriteLine($"Platform: {Platform} \nRecorded: {(IsRecorded ? "Yes" : "No")}");
        }
    }

    // Subclass: PaidOnlineCourse
    internal class PaidOnlineCourse : OnlineCourse
    {
        private double Fee;
        private double Discount; // in percentage

        public void SetPaidCourseDetails(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        {
            SetOnlineCourseDetails(courseName, duration, platform, isRecorded);
            this.Fee = fee;
            this.Discount = discount;
        }

        public override void DisplayCourseInfo()
        {
            base.DisplayCourseInfo();
            double finalPrice = Fee - (Fee * (Discount / 100));
            Console.WriteLine($"Fee: ${Fee} \nDiscount: {Discount}% \nFinal Price: ${finalPrice}");
        }
    }

    // Main Program
    internal class Program7
    {
        public static void Main()
        {
            // Creating objects for each class
            Course basicCourse = new Course();
            basicCourse.SetCourseDetails("C# Fundamentals", 4);

            OnlineCourse onlineCourse = new OnlineCourse();
            onlineCourse.SetOnlineCourseDetails("Java Programming", 6, "Udemy", true);

            PaidOnlineCourse paidCourse = new PaidOnlineCourse();
            paidCourse.SetPaidCourseDetails("Full Stack Development", 12, "GeekForGeeks", true, 300, 20);

            // Storing them in an array (Polymorphism)
            Course[] courses = { basicCourse, onlineCourse, paidCourse };

            // While loop for user interaction
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. View Basic Course Details");
                Console.WriteLine("2. View Online Course Details");
                Console.WriteLine("3. View Paid Online Course Details");
                Console.WriteLine("4. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

               else if (choice >= 1 && choice <= 3)
                {
                    Console.WriteLine("\nCourse Details:");
                    courses[choice - 1].DisplayCourseInfo();
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