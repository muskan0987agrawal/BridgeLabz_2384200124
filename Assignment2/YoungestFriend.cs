/*  using System;
  
  class YoungestFriend{
  
   //function to calculate youngest friend
    static void CalculateYoungestFriend(int ageAmar, int ageAkbar, int ageAnthony){
	
	 if((ageAmar < ageAkbar) && (ageAmar < ageAnthony)){
        Console.WriteLine("Amar is youngest among friend"); 
	}
	else if((ageAkbar < ageAmar) && (ageAkbar < ageAnthony)){
	  Console.WriteLine("Akbar is youngest among friend"); 
	  }
	else if((ageAnthony < ageAmar) && (ageAnthony < ageAkbar)){
	Console.WriteLine("Anthony is youngest among friend"); 
	}
	else{
	Console.WriteLine("No one is youngest among friend"); 
	}
	}
	
    static void CalculateTallestFriend(double heightAmar, double heightAkbar, double heightAnthony){
	
	if((heightAmar> heightAkbar)&& (heightAmar > heightAnthony)){
	  Console.WriteLine("Amar is tallest among friend"); 
	}
	
	else if((heightAkbar > heightAmar) && (heightAkbar >  heightAnthony)){
	 Console.WriteLine("Akbar is tallest among friend"); 
	}
	
	else if((heightAnthony > heightAmar) && (heightAnthony >heightAkbar)){
	 Console.WriteLine("Akbar is tallest among friend"); 
	}
	
	else{
	 Console.WriteLine("No one is tallest among friend"); 
	}
   }	 
   
  
		static void Main(){
		//Input: take the age and height of Amar, Akbar, Anthony
	      Console.Write("Enter the age of Amar: ");
         int ageAmar = Convert.ToInt32(Console.ReadLine());
		 
		  Console.Write("Enter the height of Amar(in cm): ");
         double heightAmar = Convert.ToDouble(Console.ReadLine());
  
          Console.WriteLine();
 
		  Console.Write("Enter the age of Akbar: ");
         int ageAkbar = Convert.ToInt32(Console.ReadLine());
  
          Console.Write("Enter the height of Akbar(in cm): ");
        double heightAkbar = Convert.ToDouble(Console.ReadLine());
  
          Console.WriteLine();
		  
          Console.Write("Enter the age of Anthony: ");
         int ageAnthony = Convert.ToInt32(Console.ReadLine());
            
		  Console.Write("Enter the height of Anthony(in cm): ");
         double heightAnthony = Convert.ToDouble(Console.ReadLine());
		  
		   Console.WriteLine();
		   
		  CalculateYoungestFriend(ageAmar, ageAkbar, ageAnthony); //call without creating a object
		   Console.WriteLine();
		  CalculateTallestFriend(heightAmar, heightAkbar, heightAnthony);
		 }
}
*/