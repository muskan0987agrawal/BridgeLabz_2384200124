﻿/* using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace FileHandling
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public static object JsonSerializer { get; private set; }

        // Constructor
        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary}");
        }
    }

    internal class Program
    {
        static string filePath = "C:\\Users\\khant\\OneDrive\\Desktop\\employees.json"; // File path for storing employees

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Vanshita", "HR", 50000),
                new Employee(2, "Simran", "IT", 75000),
                new Employee(3, "Misti", "Finance", 60000)
            };

            try
            {
                // Serialize employee list to JSON file
                SerializeEmployees(employees);
                Console.WriteLine(" Employee data serialized successfully!\n");

                // Deserialize employee list from JSON file
                List<Employee> deserializedEmployees = DeserializeEmployees();
                Console.WriteLine(" Deserialized Employee List:");
                foreach (var emp in deserializedEmployees)
                {
                    emp.Display();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Serialize the list of employees and save to a file
        static void SerializeEmployees(List<Employee> employees)
        {
            string jsonString = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonString);
        }

        // Deserialize employees from the JSON file
        static List<Employee> DeserializeEmployees()
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Error: Employee data file not found.");

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Employee>>(jsonString);
        }
    }
}
*/