/*using System;
namespace utilityfunction
class FootballTeam{
		static int[] GetRandomHeightArr(int size){
			// Create an instance of Random
			Random random = new Random();
			
			int[] height = new int[size];
			Console.WriteLine("Enter the height in cm: ");
			for(int i=0; i<height.Length; i++){
				// Generate a random number within a specific range
                height[i] = random.Next(150,250);
			}
			return height;
		}
		
		static int SumArray(int[] arr){
			int sum=0;
			for(int i=0 ;i<arr.Length;i++){
				sum += arr[i];
			}
			return sum;
		}
		
		static int FindMeanHeight(int sum, int size){
			int meanHeight =  sum / size;
			return meanHeight;
		}
		
		static int ShortestHeight(int[] arr){
			int shortest = arr[0];
			for(int i=1;i<arr.Length;i++){
				if(shortest>arr[i]){
					shortest=arr[i];
				}
			}
			return shortest;
		}
		
	   static int TallestHeight(int[] arr){
			int tallest = arr[0];
			for(int i=1;i<arr.Length;i++){
				if(tallest < arr[i]){
					tallest=arr[i];
				}
			}
			return tallest;
		}
	
	  static void Main(){
		//Generate height for 11 players
		int size = 11;
		Console.WriteLine("Printing the height of Student: ");
		int[] RandomHeight = GetRandomHeightArr(size);
		for(int i=0 ;i<RandomHeight.Length ; i++){
			Console.Write(RandomHeight[i] + " ");
		}
		
		int findSumArray = SumArray(RandomHeight);
		Console.WriteLine($"\n Sum of the height: {findSumArray}");
		
		int findMean = FindMeanHeight(findSumArray,size);
		Console.WriteLine($"Mean of the height: {findMean}");
		
		int shortestHeight = ShortestHeight(RandomHeight);
		Console.WriteLine($"Shortest height: {shortestHeight}");
		
		int tallestHeight = TallestHeight(RandomHeight);
		Console.WriteLine($"Tallest height: {tallestHeight}");
	}
}
		*/