/*using System;

class PrimeNumberChecker {
    // Function to check if a number is prime
    static bool IsPrime(int number) {
        if (number < 2) return false; // 0 and 1 are not prime numbers

        for (int i = 2; i * i <= number; i++) { // Check divisibility up to √number
            if (number % i == 0) return false; // If divisible, it's not prime
        }

        return true; // If no divisors found, it's prime
    }

    static void Main() {
        Console.Write("Enter a number to check if it's prime: ");
        int number = int.Parse(Console.ReadLine());

        // Checking if the number is prime
        if (IsPrime(number))
            Console.WriteLine($"{number} is a prime number.");
        else
            Console.WriteLine($"{number} is not a prime number.");
    }
}
*/