//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPs1
//{
//    internal class Patient
//    {
//        //static variable
//        private static string HospitalName = "Apolo Hospital";
//        private static int totalPatient = 0;// Count of total patients
//        private static int patientCounter = 1000; // Unique ID generator
//        //instance variable
//        private string name;
//        private int age;
//        private string ailment;
//        private readonly int patientID; // Readonly: cannot be changed
       
//        //Constructor using this
//        public Patient( string name, int age, string ailment)
//        {
//            this.patientID = patientCounter++;
//            this.name = name;
//            this.age = age;
//            this.ailment = ailment;
//            totalPatient++;
//        }


//        // Static method to get total patients
//        public static int GetTotalPatients()
//        {
//            return totalPatient;
//        }

//        // Display patient details
//        public void DisplayPatient()
//        {
//            if (this is Patient) {
//                Console.WriteLine($"Patient ID : {patientID}");
//                Console.WriteLine($"Patient Name: {name}");
//                Console.WriteLine($"Patient Age: {age}");
//                Console.WriteLine($"Ailment :  {ailment}");
//                Console.WriteLine($"Hospital Name : {HospitalName}");
//            }
//            else
//            {3.
//                Console.WriteLine("Invalid detail");
//            }
//        }


//    }

//    class Program
//    {
//       public  static void Main()
//        {
//            Patient[] patients = new Patient[10];// Fixed array for 10 patients
//            int count = 0; // Counter for patients
//            bool running = true;
//            while (running)
//            {
//                Console.WriteLine("\nEnter '1' to Admit Patient, '2' to View Patients, '3' to Get Total Patients, or '4' to Exit.");
//                string choice = Console.ReadLine();

//                if (choice == "1")
//                {
//                    if (count >= 10)
//                    {
//                        Console.WriteLine(" Hospital is full! Cannot admit more patients.");
//                    }
//                    else
//                    {
//                        Console.Write("Enter Patient Name: ");
//                        string name = Console.ReadLine();
//                        Console.Write("Enter Age: ");
//                        int age = Convert.ToInt32(Console.ReadLine());
//                        Console.Write("Enter Ailment: ");
//                        string ailment = Console.ReadLine();

//                        patients[count] = new Patient(name, age, ailment);
//                        count++;
//                        Console.WriteLine("Patient Admitted!");
//                    }
//                }
//                else if (choice == "2")
//                {
//                    if (count == 0)
//                    {
//                        Console.WriteLine(" No patients admitted yet.");
//                    }
//                    else
//                    {
//                        for (int i = 0; i < count; i++)
//                        {
//                            patients[i].DisplayPatient();
//                        }
//                    }
//                }
//                else if (choice == "3")
//                {
//                    Console.WriteLine($" Total Patients Admitted: {Patient.GetTotalPatients()}");
//                }
//                else if (choice == "4")
//                {
//                    running = false;
//                    Console.WriteLine(" Exiting Hospital System. Stay Healthy!");
//                }
//                else
//                {
//                    Console.WriteLine(" Invalid choice. Please enter 1, 2, 3, or 4.");
//                }
//            }

//        }
//    }

    
//}