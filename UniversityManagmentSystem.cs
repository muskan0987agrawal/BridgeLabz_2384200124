/*using System;

class Student
{
    // Public attribute (accessible from anywhere)
    public int rollNumber;

    // Protected attribute (accessible within this class & derived classes)
    protected string name;

    // Private attribute (only accessible within this class)
    private double CGPA;

    // Constructor to initialize values
    public Student(int roll, string studentName, double studentCGPA)
    {
        rollNumber = roll;
        name = studentName;
        CGPA = studentCGPA;
    }

    // Public method to get CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public method to set CGPA (ensuring a valid value)
    public void SetCGPA(double newCGPA)
    {
        if (newCGPA >= 0.0 && newCGPA <= 10.0)
        {
            CGPA = newCGPA;
            Console.WriteLine($"CGPA updated successfully for {name}.");
        }
        else
        {
            Console.WriteLine("Invalid CGPA! Please enter a value between 0.0 and 10.0.");
        }
    }

    // Display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Roll Number: {rollNumber}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"CGPA: {CGPA}\n");
    }
}

// Subclass demonstrating use of protected members
class PostgraduateStudent : Student
{
    // Additional attribute for PG students
    public string researchTopic;

    // Constructor using base class initialization
    public PostgraduateStudent(int roll, string studentName, double studentCGPA, string topic)
        : base(roll, studentName, studentCGPA)
    {
        researchTopic = topic;
    }

    // Display PG student details (Accessing protected member 'name')
    public void DisplayPGStudentDetails()
    {
        Console.WriteLine($"Roll Number: {rollNumber}");
        Console.WriteLine($"Name (from protected member): {name}");
        Console.WriteLine($"Research Topic: {researchTopic}\n");
		
    }
}

class UniversityManagmentSystem
{
    static void Main()
    {
        // Creating a Student object
        Student s1 = new Student(101, "Amit Sharma", 8.5);
        s1.DisplayStudentDetails();

        // Accessing and modifying CGPA using public methods
        Console.WriteLine("Updating CGPA...");
        s1.SetCGPA(9.2);
        Console.WriteLine($"Updated CGPA: {s1.GetCGPA()}\n");

        // Creating a PostgraduateStudent object
        PostgraduateStudent pg1 = new PostgraduateStudent(201, "Riya Mehta", 9.0, "Artificial Intelligence");
        pg1.DisplayPGStudentDetails();
    }
}
*/