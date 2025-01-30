/*using System;


class RemoveSpecialCharacter{
	static void RemoveOccurrence(string str, char removeChar){
		string newStr ="";
		foreach(char c in str){
            if (c == removeChar) // Only add characters that are not equal to removeChar
            {
                newStr += ' ';
            }		
			else
			{
				newStr += c;
			}
				
		}
		Console.WriteLine($"Modified String : {newStr}");
	}
	static void Main(){
		Console.Write("Enter the String: ");
        string input = Console.ReadLine();
		Console.Write("Character to remove: ");
        char remove = Convert.ToChar(Console.ReadLine()); // Convert string to char
              
	    RemoveOccurrence(input, remove);
	}
}
*/