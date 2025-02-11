using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    internal class Car : Vehicle, IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return days * RentalRate;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.1;
        }
        public string GetInsuranceDetails()
        {
            return "Car insurance is 10% of rental rate.";
        }

    }

    }

