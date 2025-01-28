/*using System;

class RandomValues
{
    // Method to generate an array of 4-digit random numbers
    public int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000); // Generates a random number between 1000 and 9999
        }

        return numbers;
    }

    // Method to find the average, min and max of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        double[] result = new double[3];
        
        double sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int num in numbers)
        {
            sum += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        result[0] = sum / numbers.Length;  // Average
        result[1] = min;                   // Minimum
        result[2] = max;                   // Maximum

        return result;
    }

    static void Main()
    {
        RandomValues randomValues = new RandomValues();
        
        // Step 1: Generate 5 4-digit random numbers
        int size = 5;
        int[] randomNumbers = randomValues.Generate4DigitRandomArray(size);

        // Print the generated random numbers
        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int number in randomNumbers)
        {
            Console.WriteLine(number);
        }

        // Step 2: Find average, min, and max values
        double[] stats = randomValues.FindAverageMinMax(randomNumbers);

        // Step 3: Display the results
        Console.WriteLine($"\nAverage: {stats[0]:F2}");
        Console.WriteLine($"Minimum: {stats[1]}");
        Console.WriteLine($"Maximum: {stats[2]}");
    }
}
*/