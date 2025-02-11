using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineFoodSystem
{
    internal interface IDiscountable
    {
        void ApplyDiscount();
        string GetDiscountDetails();
    }
}
