/*using System;
class TwoDArray{
  void CopyingArray()
  {
      //Take user input for rows and column
       Console.Write("Enter the size of row: ");
      int rowSize = int.Parse(Console.ReadLine());	 
	  Console.Write("Enter the size of column: ");
	  int columnSize = int.Parse(Console.ReadLine());	 
	 
	   // Declare and initialize the 2D Array
        int[,] matrix = new int[rowSize, columnSize];
		
        // Input the elements of the 2D Array
        Console.WriteLine("Enter the elements of the 2D Array:");
        for (int i = 0; i < rowSize; i++)
        {
            for (int j = 0; j < columnSize; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

	    // Display the elements
		 Console.WriteLine("The elements of the 2D Array are:");
        for (int i = 0; i < rowSize; i++)
        {
            for (int j = 0; j < columnSize; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
         
		 //Copying the 2D array in 1D
		 int[] array = new int[rowSize * columnSize]; 
		 int index = 0;
		  for (int i = 0; i < rowSize; i++)
          {
            for (int j = 0; j < columnSize; j++)
            {
			  array[index]=matrix[i,j]; //copying the elements from 2d array into the 1d array
			  index++;
			}
		  }
			//Printing the 1D Array
			Console.WriteLine("Printing the 1D array");
			for(int i=0;i<array.Length; i++)
			{
			  Console.Write(array[i]+" ");
			 }
	}
	
	static void Main(){
	 TwoDArray t = new TwoDArray();//creating an object
	 t.CopyingArray(); //calling the function
	 }
}
*/