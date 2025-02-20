/* using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EmployeeJsonSerialization // Added a namespace
{
    class EmployeeManager
    {
        public static void SaveEmployeesToJson(List<Employee> employees, string filePath)
        {
            try
            {
                string json = JsonSerializer.Serialize(employees);
                File.WriteAllText(filePath, json);
                Console.WriteLine($"Employees saved to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving: {ex.Message}");
            }
        }

        public static List<Employee> LoadEmployeesFromJson(string filePath)
        {
            List<Employee> employees = null;
            try
            {
                string readJson = File.ReadAllText(filePath);
                employees = JsonSerializer.Deserialize<List<Employee>>(readJson);
                Console.WriteLine($"Employees loaded from {filePath}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
                return new List<Employee>(); // Return empty list
            }
            catch (JsonException)
            {
                Console.WriteLine($"Invalid JSON: {filePath}");
                return new List<Employee>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading: {ex.Message}");
            }
            return employees;
        }

        static void Main()
        {
            string filePath = "employees.json"; // Or a full path

            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Muskan", Department = "IT", Salary = 600000 },
                new Employee { Id = 2, Name = "Diya", Department = "Law", Salary = 750000 }
            };

            SaveEmployeesToJson(employees, filePath);

            List<Employee> deserializedEmployees = LoadEmployeesFromJson(filePath);

            if (deserializedEmployees != null) // Check for null
            {
                foreach (var emp in deserializedEmployees)
                {
                    Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
                }
            }
            Console.ReadKey();
        }
    }

    class Employee // Employee class can be outside EmployeeManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
}
*/