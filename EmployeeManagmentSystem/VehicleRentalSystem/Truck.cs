using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    //Truck Class
    internal class Truck : Vehicle, IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return days * RentalRate * 1.2; // 20% extra charge
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.15;
        }

        public string GetInsuranceDetails()
        {
            return "Truck insurance is 15% of rental rate.";
        }
       
        
    }
}

