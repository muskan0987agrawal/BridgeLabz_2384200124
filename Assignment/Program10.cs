//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the number of sentences: ");
//        int n = int.Parse(Console.ReadLine());

//        string[] sentences = new string[n];

//        Console.WriteLine("Enter the sentences:");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Sentence {i + 1}: ");
//            sentences[i] = Console.ReadLine();
//        }

//        Console.Write("\nEnter the word to search: ");
//        string searchWord = Console.ReadLine();

//        string result = FindSentenceWithWord(sentences, searchWord);

//        if (result != null)
//            Console.WriteLine($"\nFirst sentence containing '{searchWord}': {result}");
//        else
//            Console.WriteLine($"\nNo sentence contains the word '{searchWord}'.");
//    }

//    static string FindSentenceWithWord(string[] sentences, string word)
//    {
//        foreach (string sentence in sentences)
//        {
//            if (sentence.ToLower().Contains(word.ToLower())) 
//                return sentence; // Return the first matching sentence
//        }
//        return null; // If no match is found
//    }
//}
