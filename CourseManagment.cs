/*using System;

class Course{
	// Instance variables
	string courseName;
	string duration;
	double fee;
	
	//declare class variable  (shared across all instances)
	 static string instituteName = "Udemy ";
	
	//Constructor to initialize the value
	public Course(string courseName, string duration, double fee){
		this.courseName = courseName;
		this.duration=duration;
		this.fee = fee;
	}
	
	
	//Instance Method
	public void DisplayCourseDetails(){
		  Console.WriteLine($"Course Name: {courseName}");
        Console.WriteLine($"Duration: {duration}");
        Console.WriteLine($"Fee: {fee:C}");
        Console.WriteLine($"Institute: {instituteName}\n");
	}
		
	 // Class method to update the institute name for all courses
    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
        Console.WriteLine($"Institute Name updated to: {instituteName}\n");
    }
}

class CourseManagment{
	 static void Main()
    {
        // Create Course objects
        Course c1 = new Course("C# Programming", "3 Months", 2000);
        Course c2 = new Course("Java Development", "4 Months", 2500);
        Course c3 = new Course("Web Development", "6 Months", 3000);

        // Display initial course details
        Console.WriteLine("Initial Course Details:");
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
        c3.DisplayCourseDetails();

        // Update the institute name using the class method
        Course.UpdateInstituteName("Tech Academy");

        // Display course details after updating the institute name
        Console.WriteLine("Course Details after Institute Name Update:");
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
        c3.DisplayCourseDetails();
    }
}
*/