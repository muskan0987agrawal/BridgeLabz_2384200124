using System;

class Replace{
	static string ReplaceWord(string str, string oldWord, string newWord){
	    string result="";
		string temp="";
		
		for(int i=0;i<str.Length;i++){
			if( str[i] ==' ' ){
				if(temp == oldWord){
					result += newWord;
				}
				else{
					result += temp;
				}
		
				result += " ";
				temp = "";
				
			}
			else{
				temp += str[i];
			}
		}
		// Check the last word (because there might not be a space at the end)
        if (temp == oldWord) {
            result += newWord;
        } else {
            result += temp;
        }
		return result;
	}
	
	static void Main(){
		 Console.Write("Enter the Sentence: ");
        string sentence = Console.ReadLine();
        
        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();
        
        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        string updatedSentence = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine($"Modified Sentence: {updatedSentence}");
    }
}
				
			