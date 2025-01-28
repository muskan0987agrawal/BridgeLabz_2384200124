using System;

class OTPGenerator{
	static int GenerateOTP(){
		Random random = new Random();
		int otp = random.Next(100000 , 1000000);
		return otp;
	}
	
	static bool AreOTPsUnique(int[] otps){
		for(int i=0 ;i<otps.Length ;i++){
			for(int j=i+1; j<otps.Length; j++){
				if(otps[i] == otps[j]) {  // If any two OTPs are the same, return false
					return false;
				}
			}
		}
		return true;
	}
	
	static void Main(){
		int[] otps = new int[10];  // Array to store the 10 OTP numbers generated

        // Generate 10 OTPs and store them in the array
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOTP();
        }
		
		// Display the OTP numbers generated
        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }

        // Check if the OTPs are unique
        if (AreOTPsUnique(otps))
        {
            Console.WriteLine("All OTPs are unique.");
        }
        else
        {
            Console.WriteLine("Some OTPs are duplicates.");
        }
    }
}