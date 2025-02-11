using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class DVD : LibraryItem, IReservable
    {
        private bool isReserved = false;

        public override int GetLoanDuration()
        {
            return 5;
        }

        public void ReserveItem(string user)
        {
            if (!isReserved)
            {
                isReserved = true;
                Console.WriteLine($"DVD '{Title}' reserved for {user}.");
            }
            else
            {
                Console.WriteLine($" DVD '{Title}' is already reserved.");
            }
        }
        public bool CheckAvailability()
        {
            return !isReserved;
        }
    }
}