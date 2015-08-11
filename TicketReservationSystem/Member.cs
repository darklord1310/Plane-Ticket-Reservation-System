using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    class Member : Customer
    {
        public Member() { }

        public Member(string name, string id, string contact, char memberShip)
                    : base(name, id, contact, memberShip)
        { }

        public override void addReserveList(Reservation reserve)
        {
            if (reserveList.Length > 3)
                luckyDraw = true;

            for (int i = 0; i < 4; i++){
                if (reserveList[i] == null){
                    reserveList[i] = reserve;
                    break;
                }
            }
        }

        public override double calTotalFee()
        {
            for (int i = 0; i < 4; i++)
            {
                if (reserveList[i] != null)
                { totalFee += reserveList[i].calFee(); }
            }
            return totalFee *95/100 ;  // member has 5% discount 
        } 
    }
}
