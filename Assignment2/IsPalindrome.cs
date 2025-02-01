/*using System;

class PalindromeString{
	static string GetWord(){
	    Console.Write("Enter a string to Check Palindrome : ");
		return Console.ReadLine();
	}
	static bool IsPalindrome(string str){
			int left = 0;
			int right= str.Length-1;
			
			while(left < right){
				 char leftChar = (str[left] >='A' && str[right] <='Z') ?(char)(str[left]+32): str[left];
				 char rightChar= (str[right] >='A' && str[right] <='Z') ?(char)(str[right]-32) :str[right];
				 
				 // Check if characters are equal
				if (leftChar != rightChar)
					return false;

				left++;
				right--;
			}
        return true;
    }
	
	static void DisplayResult(string str, bool IsPalindrome){
		if(IsPalindrome)
			 Console.WriteLine($"'{str}' is a palindrome.");
        else
            Console.WriteLine($"'{str}' is not a palindrome.");
    }
	
	static void Main(){
		string input = GetWord();
		bool result = IsPalindrome(input);
		DisplayResult(input, result);
	}
}
*/