using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    class Regular : Customer
    {
        public Regular() { }

        public Regular(string name, string id, string contact, char memberShip)
            : base(name, id, contact, memberShip)
        { }

        public override void addReserveList(Reservation reserve)
        {
            for (int i = 0; i < 2; i++){
                if (reserveList[i] == null){
                    reserveList[i] = reserve;
                    break;
                }
            }
        }

        public override double calTotalFee()
        {           
            for (int i = 0; i < 2; i++){
                if (reserveList[i] != null)
                { totalFee += reserveList[i].calFee(); }
            }
            return totalFee;
        } 
    }
}
