/*using System;

class PalindromeString{
	static bool IsPalindromnString(string str){
		string newstr = str.ToLower();
		int lastidx = str.Length-1;
		for(int i=0; i<newstr.Length/2; i++){
			if(newstr[i]!= newstr[lastidx]) return false;
			lastidx--;
		}
		return true;
	}
	
	static void Main(){
	  
	  Console.Write("Enter the String: ");
	  string str = Console.ReadLine();
	  if(IsPalindromnString(str)) Console.WriteLine($"{str} is Palindrome String");
	  else Console.WriteLine($"{str} is not a Palindrome String");
	}
}
		*/	