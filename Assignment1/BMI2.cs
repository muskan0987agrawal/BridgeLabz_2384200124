class BMI
{
    static void BMIArray()
    {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        // Multi-dimensional array to store weight, height, and BMI
        double[,] personData = new double[numberOfPersons, 3]; // 3 columns: weight, height, BMI
        string[] weightStatus = new string[numberOfPersons]; // Array to store weight status

        // Input: Weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Enter details for Person {i + 1}:");

            // Input weight
            while (true)
            {
                Console.Write("Weight (kg): ");
                if (double.TryParse(Console.ReadLine(), out personData[i, 0]) && personData[i, 0] > 0)
                {
                    break;  // Break out of the loop if the input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for weight.");
                }
            }

            // Input height
            while (true)
            {
                Console.Write("Height (m): ");
                if (double.TryParse(Console.ReadLine(), out personData[i, 1]) && personData[i, 1] > 0)
                {
                    break;  // Break out of the loop if the input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for height.");
                }
            }
        }

        // Calculate BMI and determine weight status
        for (int i = 0; i < numberOfPersons; i++)
        {
            personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]); // BMI formula

            // Determine weight status based on BMI
            if (personData[i, 2] <= 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (personData[i, 2] > 18.5 && personData[i, 2] < 24.9)
            {
                weightStatus[i] = "Normal";
            }
            else if (personData[i, 2] >= 25.0 && personData[i, 2] < 39.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }
		

        // Output: Display height, weight, BMI, and weight status for each person
        Console.WriteLine("\nResults:");
        Console.WriteLine("Person\tHeight(m)\tWeight(kg)\tBMI\t\tStatus");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"{i + 1}\t{personData[i, 1]:0.00}\t\t{personData[i, 0]:0.00}\t\t{personData[i, 2]:0.00}\t\t{weightStatus[i]}");
        }
    }

    static void Main()
    {
        BMIArray();
    }
}

