/* using System;
class CalulateMeanHeight{
   void HeightOfPlayer(){
     
	int sizeOfPlayer = 11 ;
	double[] arrHeight = new double[sizeOfPlayer]; //create an array to stores the height
	
	Console.WriteLine("Enter the height of player[seperated by space]: ");
		
	//loop for taking the height of the player
	double totalHeight = 0; //declare and initialize the variable
	for(int i=0; i<sizeOfPlayer; i++){
      Console.Write($"Height of Player{i+1}: ");	
     
	 // Check if the input array matches the expected size of players
	  string input = Console.ReadLine(); 
	   // Check if the user enter empty string
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.Error.WriteLine("Invalid expression");
            Environment.Exit(0);
        } 
	  arrHeight[i] = Convert.ToDouble(input);
	 
       
	  totalHeight+= arrHeight[i];
	 }
	 
	 //Calculate mean of the Players height
	 double mean;
	  mean = totalHeight/ sizeOfPlayer;
	 
	  
	  //Printing the mean height of player'
	  Console.WriteLine($"Mean Height of the football team is {mean}");
	 }
	 
	 static void Main(){
	  CalulateMeanHeight h =new CalulateMeanHeight();
	  h.HeightOfPlayer();
	 }
}
	 
	*/  
	  
	  