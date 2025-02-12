// See https://aka.ms/new-console-template for more information

/*
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public char Grade { get; set; }

    public Student(int RollNumber, string Name, int age, char Grade)
    {
        this.RollNumber = RollNumber;
        this.Name = Name;
        this.Age = age;
        this.Grade = Grade;
    }

    public void ShowStudentDetail()
    {
        Console.WriteLine($"Rollno: {this.RollNumber}, Name: {this.Name}, Age: {this.Age}, Grade: {this.Grade}");
    }
}

public class Node
{
    public Student student;
    public Node next;
    public Node(Student student)
    {
        this.student = student;
        next = null;
    }
}

public class StudentList
{
    public Node head;
    public Node tail;
    public static int size = 0;
    public StudentList()
    {
        this.head = null;
        this.tail = null;
    }
    public void AddBeg(Student student)
    {
        Node newNode = new Node(student);

        if (head == null) { head = tail = newNode; }
        else
        {
            newNode.next = head;
            head = newNode;
        }
    }

    public void AddLast(Student student)
    {
        Node newNode = new Node(student);
        if (head == null) { head = tail = newNode; }
        else
        {
            tail.next = newNode;

            tail = newNode;
        }
        size++;
    }

    public void AddInBetween(Student student, int pos)
    {
        Node newNode = new Node(student);
        Node temp = head;
        Node prev = null;
        int count = 1;

        if (pos < 1 || pos > size + 1)
        {
            Console.WriteLine("Invalid Position!");
            return;
        }

        if (pos == 1)
        {
            AddBeg(student);
            return;
        }
        if (pos == size)
        {
            AddLast(student);
            return;
        }


        // Traverse to the node just before the insertion point
        while (count < pos - 1)
        {
            temp = temp.next;
            count++;
        }

        // Insert new node
        newNode.next = temp.next;
        temp.next = newNode;

        size++;

        //  if (temp!=null)
        //  {
        //      prev = temp;
        //      temp = temp.next;
        //      count++;
        //  }
        //  prev.next = newNode;
        ////  temp.next = newNode;
        //  newNode.next = temp;
    }


    public void DeleteByRollno(int rollno)
    {
        //Node temp = head;
        //Node prev = null;
        if (head == null) { Console.WriteLine("No Student Exist"); return; }
        if (head.student.RollNumber == rollno)
        {
            head = head.next;
            //  size--;
            return;
        }
        Node temp = head;
        Node prev = null;
        while (temp != null && temp.student.RollNumber != rollno)
        {
            prev = temp;
            temp = temp.next;

        }
        if (temp == null)
        {
            Console.WriteLine($"{rollno} rollno not exist");
            return;

        }
        prev.next = temp.next;


    }
    public void Display()
    {
        Node temp = head;
        if (temp == null)
        {
            Console.WriteLine("No student exists!");
            return;
        }

        while (temp != null)
        {
            temp.student.ShowStudentDetail();
            temp = temp.next;
        }
    }

    public void SearchStudentByRollno(int rollno)
    {
        Node temp = head;
        if (temp == null)
        {
            Console.WriteLine("No Student exists!");
            return;
        }

        if (head.student.RollNumber == rollno)
        {
            Console.WriteLine("Student found \n");
            head.student.ShowStudentDetail();
        }
        while (temp != null && temp.student.RollNumber != rollno)
        {
            temp = temp.next;
        }

        if (temp == null)
        {
            Console.WriteLine($" student whose rollno {rollno} does not exist");
            return;

        }
        Console.WriteLine($"Detail of student of rollno {rollno} is: \n");
        temp.student.ShowStudentDetail();
    }

    public void UpdateGradeByRollno(int rollno, char Updategrade)
    {
        Node temp = head;
        if (temp == null)
        {
            Console.WriteLine("No Student exists!");
            return;
        }

        if (head.student.RollNumber == rollno)
        {
            head.student.Grade = Updategrade;

        }
        while (temp != null && temp.student.RollNumber != rollno)
        {
            temp = temp.next;
        }

        if (temp == null)
        {
            Console.WriteLine($" student whose rollno {rollno} does not exist");
            return;

        }
        Console.WriteLine($"Detail of student of rollno {rollno} is: \n");
        if (temp.student.RollNumber == rollno)
        {
            temp.student.Grade = Updategrade;
        }
        temp.student.ShowStudentDetail();
    }
    public class Program
    {
        public static void Main()
        {
            StudentList list = new StudentList();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n----- Student Management System -----");
                Console.WriteLine("1. Add Student (Beginning)");
                Console.WriteLine("2. Add Student (End)");
                Console.WriteLine("3. Add Student (Specific Position)");
                Console.WriteLine("4. Delete Student by Roll No");
                Console.WriteLine("5. Search Student by Roll No");
                Console.WriteLine("6. Update Student Grade by Roll No");
                Console.WriteLine("7. Display Students");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);
                if (!isValidChoice)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Roll No: ");
                        int roll1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name1 = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter Grade: ");
                        char grade1 = char.Parse(Console.ReadLine());
                        list.AddBeg(new Student(roll1, name1, age1, grade1));
                        break;

                    case 2:
                        Console.Write("Enter Roll No: ");
                        int roll2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name2 = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter Grade: ");
                        char grade2 = char.Parse(Console.ReadLine());
                        list.AddLast(new Student(roll2, name2, age2, grade2));
                        break;

                    case 3:
                        Console.Write("Enter Roll No: ");
                        int roll3 = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name3 = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age3 = int.Parse(Console.ReadLine());
                        Console.Write("Enter Grade: ");
                        char grade3 = char.Parse(Console.ReadLine());
                        Console.Write("Enter Position: ");
                        int position = int.Parse(Console.ReadLine());
                        list.AddInBetween(new Student(roll3, name3, age3, grade3), position);
                        break;

                    case 4:
                        Console.Write("Enter Roll No to delete: ");
                        int delRoll = int.Parse(Console.ReadLine());
                        list.DeleteByRollno(delRoll);
                        break;

                    case 5:
                        Console.Write("Enter Roll No to search: ");
                        int searchRoll = int.Parse(Console.ReadLine());
                        list.SearchStudentByRollno(searchRoll);
                        break;

                    case 6:
                        Console.Write("Enter Roll No to update: ");
                        int updateRoll = int.Parse(Console.ReadLine());
                        Console.Write("Enter new Grade: ");
                        char newGrade = char.Parse(Console.ReadLine());
                        list.UpdateGradeByRollno(updateRoll, newGrade);
                        break;

                    case 7:
                        list.Display();
                        break;

                    case 8:
                        exit = true;
                        Console.WriteLine("Exiting the program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 8.");
                        break;
                }
            }
        }
    }
}*/