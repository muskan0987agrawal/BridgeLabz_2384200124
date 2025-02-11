using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal interface IReservable
    {
        void ReserveItem(string user);
        bool CheckAvailability();
    }
}
