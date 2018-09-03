using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Room
    {
        //Room has a few properties: Occupation, payment is done and the number of rooms.
        public Boolean Occupied { get; set; }
        public Boolean Paid { get; set; }
        public List<bool> Payments { get; set; }

        public List<bool> listPayments = new List<bool>(new bool[] {true, true, true, true, false, true, true, true, true, true });
        
      



    }
}
