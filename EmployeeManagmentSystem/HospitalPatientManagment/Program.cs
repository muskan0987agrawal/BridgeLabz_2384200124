// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

// Interface for Medical Records
interface IMedicalRecord
{
    void AddRecord(string diagnosis, string history);
    void ViewRecords();
}

//Abstract class Patient
abstract class Patient : IMedicalRecord
{
    private int patientId;
    private string name;
    private int age;
    private string diagnosis;
    private string medicalHistory;

    //Encapsulation: Properties
    public int PatientId
    {
        get { return patientId; }
        set { patientId = value > 0 ? value : 0; }
    }

    public string Name
    {
        get { return name; }
        set { name = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value > 0 ? value : 1; }
    }

    // Abstract Method for Billing
    public abstract double CalculateBill();

    // Concrete Method for Patient Details
    public virtual void GetPatientDetails()
    {
        Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}");
    }

    // IMedicalRecord Methods (Encapsulation of Diagnosis & History)
    public void AddRecord(string diagnosis, string history)
    {
        this.diagnosis = diagnosis;
        this.medicalHistory = history;
    }

    public void ViewRecords()
    {
        Console.WriteLine($"Diagnosis: {diagnosis}, Medical History: {medicalHistory}");
    }
}

//InPatient Class (Admitted Patient)
class InPatient : Patient
{
    public int DaysAdmitted { get; set; }

    public override double CalculateBill()
    {
        return DaysAdmitted * 500; // ₹500 per day charge
    }

    public override void GetPatientDetails()
    {
        base.GetPatientDetails();
        Console.WriteLine($"Days Admitted: {DaysAdmitted}, Total Bill: {CalculateBill()}");
    }
}

// OutPatient Class (Visiting Patient)
class OutPatient : Patient
{
    public double ConsultationFee { get; set; }

    public override double CalculateBill()
    {
        return ConsultationFee; // Direct Consultation Fee
    }

    public override void GetPatientDetails()
    {
        base.GetPatientDetails();
        Console.WriteLine($"Consultation Fee: {CalculateBill()}");
    }
}

// Main Program with Switch Statement
class Program
{
    static void Main()
    {
        Console.WriteLine("Hospital Patient Management System:");
        Console.WriteLine("1. Add In-Patient");
        Console.WriteLine("2. Add Out-Patient");
        Console.WriteLine("3. View Patient Details");
        Console.WriteLine("4. Add & View Medical Record");
        Console.WriteLine("Enter Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                InPatient inPatient = new InPatient();
                Console.Write("Enter Patient ID: ");
                inPatient.PatientId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Patient Name: ");
                inPatient.Name = Console.ReadLine();
                Console.Write("Enter Age: ");
                inPatient.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Days Admitted: ");
                inPatient.DaysAdmitted = Convert.ToInt32(Console.ReadLine());
                inPatient.GetPatientDetails();
                break;

            case 2:
                OutPatient outPatient = new OutPatient();
                Console.Write("Enter Patient ID: ");
                outPatient.PatientId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Patient Name: ");
                outPatient.Name = Console.ReadLine();
                Console.Write("Enter Age: ");
                outPatient.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Consultation Fee: ");
                outPatient.ConsultationFee = Convert.ToDouble(Console.ReadLine());
                outPatient.GetPatientDetails();
                break;

            case 3:
                Console.WriteLine("Patient details will be displayed after adding a patient.");
                break;

            case 4:
                Console.WriteLine("Medical records feature is only available for added patients.");
                break;

            default:
                Console.WriteLine("Invalid Choice! Try Again.");
                break;
        }
    }
}


