/*using System;

class ToggleCase{
	
	static string Toggle(string str){
		
		string newstr = ""; // Use an empty string to build the result
		
		for(int i=0; i<str.Length ;i++){
		
			if (str[i] >= 'A' && str[i] <= 'Z') 
				//  newstr += (char)(str[i] + 32); // Convert uppercase to lowercase
				newstr += (char)(str[i] - 'A' + 'a');
			else if (str[i] >= 'a' && str[i] <= 'z') 
                //newstr += (char)(str[i] - 32); // Convert lowercase to uppercase
				newstr += (char)(str[i] - 'a' + 'A');
			else 
                newstr += str[i]; // Keep non-alphabet characters unchanged
		}
		return newstr;
	}
	
	static void Main(){
		Console.Write("enter the String: ");
		string str = Console.ReadLine();
		Console.WriteLine($"Toggle Case Of the string is: {Toggle(str)}");
	}
}
*/