/*using System;
class BMI
{
  static void BMIArray()
  {
    Console.Write("Enter a number of persons: ");
    int numberOfPersons = int.Parse(Console.ReadLine());

    // Arrays to store weight, height, BMI, and weight status
    double[] weights = new double[numberOfPersons];
    double[] heights = new double[numberOfPersons];
    double[] bmis = new double[numberOfPersons];
    string[] status = new string[numberOfPersons];

    // Input: Weight and height for each person
    for (int i = 0; i < numberOfPersons; i++)
    {
      Console.Write($"Enter weight (kg) for person {i + 1}: ");
      weights[i] = double.Parse(Console.ReadLine());

      Console.Write($"Enter height (m) for person {i + 1}: ");
      heights[i] = double.Parse(Console.ReadLine());
    }

    double [] findBMI = new double[numberOfPersons];
    for (int i = 0; i < numberOfPersons; i++)
    {
      findBMI[i] = weights[i] / (heights[i] * heights[i]); // BMI formula


      if (findBMI[i] <= 18.5)
      {
        status[i] = "Underweight";
      }

      else if (findBMI[i] >= 18.5 && findBMI[i] < 24.9)
      {
        status[i] = "Normal";
      }

      else if (findBMI[i] >= 25.0 && findBMI[i] < 39.9)
      {
        status[i] = "Overweight";
      }

      else
      {
        status[i] = "Obese";
      }
    }
	 // Output: Display results for each person
        Console.WriteLine("\nResults:");
        Console.WriteLine("Person\t Height(m) \t Weight(kg) \t BMI \t \t Status");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1} \t {heights[i]:0.00} \t \t {weights[i]:0.00} \t \t {findBMI[i]:0.00}\t\t{status[i]}");
        }
	}
    static void Main()
    {
      BMIArray();
    }
  }
  */