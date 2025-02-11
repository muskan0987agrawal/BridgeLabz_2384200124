using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class Magazine : LibraryItem, IReservable
    {
        private bool isReserved = false;
        public override int GetLoanDuration()
        {
            return 7;
        }
        public void ReserveItem(string user)
        {
            if (!isReserved)
            {
                isReserved = true;
                Console.WriteLine($"Magazine'{Title}' reserved for {user}.");
            }
            else
            {
                Console.WriteLine($" Magazine '{Title}' is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return !isReserved;
        }
    }
    
}
