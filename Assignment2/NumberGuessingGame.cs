/*using System;

class NumberGuessingGame {
    static Random random = new Random();
    
    static int GenerateGuess(int low, int high) { //generate random number between low - high
        return random.Next(low, high + 1);
    }

    static char GetUserFeedback(int guess) {
        Console.Write($"Is your number {guess}? (H for High, L for Low, C for Correct): ");
        return char.ToUpper(Console.ReadLine());
    }

    static void PlayGame() {
        int low = 1, high = 100;
        int guess;
        char feedback;
        
        Console.WriteLine("\nThink of a number between 1 and 100. I will try to guess it!");
        
        do {
            guess = GenerateGuess(low, high);
            feedback = GetUserFeedback(guess);
            Console.WriteLine(); // New line for better formatting

            if (feedback == 'L') {
                low = guess + 1;
            } else if (feedback == 'H') {
                high = guess - 1;
            } else if (feedback == 'C') {
                Console.WriteLine($"Hooray! I guessed your number {guess} correctly! 🎉");
                return;
            } else {
                Console.WriteLine("Invalid input! Please enter H (High), L (Low), or C (Correct).");
            }

        } while (low <= high);

        Console.WriteLine("Hmm, something went wrong. Did you change your number? 😅");
    }

    static void Main() {
        PlayGame();
    }
}
*/