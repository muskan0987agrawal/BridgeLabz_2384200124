using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal class Bike : Vehicle, IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return days * RentalRate * 0.9; // 10% discount
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.05;
        }

        public string GetInsuranceDetails()
        {
            return "Bike insurance is 5% of rental rate.";
        }
      
    }

}
