/*using System;

class AnagramCheck{
	static bool AreAnagrams(string str1, string str2){
		// Step 1: If lengths are different, they are NOT anagrams
		if(str1.Length != str2.Length) return false;
	
		// Step 2: Convert to lowercase to make it case insensitive
        str1 = str1.ToLower();
        str2 = str2.ToLower();
		
	    // Step 3: Create frequency arrays for both strings
        int[] charCount = new int[26]; // ASCII character set
		       
	    // Step 4: Count frequency of each character
        for (int i = 0; i < str1.Length; i++)
        {
            charCount[(char)(str1[i]-'a')]++; // Increment for str1
            charCount[(char)(str2[i]-'a')]--; // Decrement for str2
        }
		
		// Step 5: Check if all counts are zero
        foreach (int count in charCount)
        {
            if (count != 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (AreAnagrams(str1, str2))
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are NOT anagrams.");
    }
}
*/