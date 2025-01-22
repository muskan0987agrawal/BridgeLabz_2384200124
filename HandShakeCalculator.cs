using System;
 
    class HandShakeCalculator // Main class
    {
	
	 // Function to calculate the maximum number of handshakes
        static int CalculateHandshakes(int numberOfStudents)
        {
            if (numberOfStudents < 2)
                return 0; // No handshakes are possible with fewer than 2 students

            return (numberOfStudents * (numberOfStudents - 1)) / 2; // Combination formula
        }
		
		
        static void Main(string[] args) // Entry point of the program
        {
            // Take the number of students as input
            Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Call the function to calculate the maximum number of handshakes
            int maxHandshakes = CalculateHandshakes(numberOfStudents);

            // Output the result
            Console.WriteLine("The number of students is "+numberOfStudents +" The maximum number of possible handshakes is "+maxHandshakes);
        }

       
    
}
