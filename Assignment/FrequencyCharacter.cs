/*using System;

class MostFrequentCharacter{
	static void FrequentCharacter(String str){
		int[] freqArr = new int[26];
		int maxFreq = 0;
        char mostFrequentChar = '\0'; // Default null character
		
		foreach(char c in str){
			freqArr[c-'a'] +=1;
			if(freqArr[c-'a'] > maxFreq) //update max frequency
			{
				maxFreq=freqArr[c-'a'];
				mostFrequentChar = c;
			}
		}
	    Console.WriteLine("Most frequencyCharacter in the string is: "+mostFrequentChar);
	}
	static void Main()
    {
        Console.Write("Enter the String: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("String is empty. No frequent character.");
        }
		else{
			FrequentCharacter(input);
		}
    }
}
*/

	
			