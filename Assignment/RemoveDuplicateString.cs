/* using System;

class RemoveDuplicateChar{
	static string RemoveDuplicacy(string str){
		string newstr="";

		for(int i=0; i<str.Length; i++){
			bool isDuplicate = false;
			// Compare the current character with the previous characters
			for(int j=0 ; j<newstr.Length ; j++){
				
				if(str[i] == newstr[j]) {
					isDuplicate = true;
					break;
				}
			}
			 // Add the character to newstr if it is not a duplicate
			if(!isDuplicate){
				 newstr += str[i];
			}
			
		}
	    return newstr;
	}
	
	static void Main(){
	  Console.Write("Enter the String: ");
	  string str = Console.ReadLine();
	  Console.WriteLine($"Original String: {str} ");
	  Console.WriteLine($"String after remove the duplicacte element: {RemoveDuplicacy(str)} ");
				
	}
}
				
			*/