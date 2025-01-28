/*using System;
	 class BMI2D
	{
	    static double GetBmi(double height, double weight){
			height/=100;
	      return weight/ (height*height);
	    }
	    
	    static String GetStatus(double bmi){
	      if(bmi<18.4) return "Underweight";
	      else if(bmi<24.9) return "Normal";
	      else if(bmi<39.9) return "Overweight";
	      else return "Obese";
	    } 
		 static void Main()
		{
		// totol number of persons
		Console.Write("enter the strenght of the person: ");
		int personCount = Convert.ToInt32(Console.ReadLine());
		// Declaring the jagged array for storing data for each person
		double[][] personData = new double[personCount][];
		String [] status = new String[personCount];
		for(int i=0; i<personCount; i++){
		
		  // Loop  to take input for prsonCount{10} person
		  personData[i] = new double[3];// Create a new array to store weight, height, and BMI for each person
		 
          Console.WriteLine($"Enter details for person {i + 1}:");

          Console.Write("Enter weight (kg): ");
          personData[i][0] = double.Parse(Console.ReadLine());  // weight

          Console.Write("Enter height (cm): ");
          personData[i][1] = double.Parse(Console.ReadLine());  // height

            // Calculate BMI for the person and store it in the 3rd column
		  personData[i][2] = GetBmi(personData[i][1], personData[i][0]);
		  status[i] = GetStatus( personData[i][2] );
		}
		
		Console.WriteLine("Person\t Height\t Weight\t BMI\t Status");
		for(int i=0;i<personCount; i++){
		  Console.WriteLine($"Person{i+1}\t {personData[i][0]}\t {personData[i][1]}\t {personData[i][2]:F2}\t {status[i]}");
		}
		}
	}
	*/