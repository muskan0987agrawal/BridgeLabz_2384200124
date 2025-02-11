using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class Book : LibraryItem, IReservable
    {
     
   private bool isReserved = false;
        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem(string user)
        {
            if (!isReserved)
            {
                isReserved = true;
                Console.WriteLine($"Book '{Title}' reserved for {user}.");
            }
            else
            {
                Console.WriteLine($" Book '{Title}' is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return !isReserved;
        }
    }
}
