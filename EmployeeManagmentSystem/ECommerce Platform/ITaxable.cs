using System;

namespace ECommerce_Platform
{
    public interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}
