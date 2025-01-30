/*using System;

class CompareTwoString{	
	static void PrintLexicographically(string s1, string s2){
		int minLength = Math.Min(s1.Length, s2.Length);
        int i = 0;

        while (i < minLength) {// Loop only till the shortest string length
			if(s1[i] > s2[i]){
				Console.WriteLine($"{s2} comes before {s1} in lexicographical order");
				break;
				
			}
			
			else if(s1[i]< s2[i]){
				Console.WriteLine($"{s1} comes before {s2} in lexicographical order");
				break;
			}
			else{
				i++;
				Console.WriteLine("Both string are equal");
				return;
			}
			
		}
	}
	static void Main(){
		Console.Write("Enter the String1: ");
		string str1 = Console.ReadLine();
		Console.Write("Enter the String2: ");
		string str2 = Console.ReadLine();
		PrintLexicographically(str1, str2);
	}
}
		
*/				