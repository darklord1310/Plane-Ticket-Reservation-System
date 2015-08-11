using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    class SeatInfo
    {
        protected string seatNumber;

        public SeatInfo(){ }
        public SeatInfo(string s)
        { setSeatNum(s); }

        public void setSeatNum(string seatNumber)
        { this.seatNumber = seatNumber; }
        public string getSeatNum(string seatNumber)
        { return this.seatNumber; }
    }
}
