/*using System;

class CountVowelConsonants{
		static int[] CountVowelConso(string str){
		    int[] arr= new int[2];
			string lower = str.ToLower();//convert to lowercase easy
			int countVowel =0;
			int countCons =0 ;
			
			foreach(char c in str){
				if(c == 'a' || c== 'e'|| c== 'i' || c=='o'|| c=='u') countVowel++;
				else countCons++;
			}
			arr[0]=countVowel;
			arr[1]=countCons;
			return arr;
		}
		
		static void Main(String[]args){
			string str ="Hello! World";
			Console.WriteLine($"Given string is: {str}");
			int[] arr = CountVowelConso(str);
			Console.WriteLine($"Vowel present in given string is: {arr[0]}");
			Console.WriteLine($"Consonants present in given string is: {arr[1]}");
		}
}
*/