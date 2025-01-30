/*using System;

class LongestWord{
 
	static int LongestWordInSentence(string str){
		string temp = "";
		string longestWord = "";
		int max= -1;
		foreach(char c in str){
			if(c == ' '  ){
				max = Math.Max(max , temp.Length);
			//	max = count;
			temp = "";
				
			}
			else{
				temp += c;
			}
			max = Math.Max(max , temp.Length);
			if(temp.Length > longestWord.Length){
				longestWord = temp;
			}
				
			
		}

		Console.WriteLine($"Longest Word is: {longestWord}");
		return max;
	}
	
	static void Main(){
		Console.Write("Enter the String: ");
		string str = Console.ReadLine();
		Console.WriteLine($"Original String: {str} ");
	    Console.WriteLine($"The Longest Word in the Sentence is: {LongestWordInSentence(str)} ");
	}
}
*/