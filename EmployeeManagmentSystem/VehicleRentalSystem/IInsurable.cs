using System;


namespace VehicleRentalSystem
{
    internal interface IInsurable
    {
       double CalculateInsurance();

        string GetInsuranceDetails();
    }
}
