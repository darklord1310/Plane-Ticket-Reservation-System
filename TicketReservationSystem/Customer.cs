using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    abstract class Customer
    {
        protected Reservation[] reserveList = new Reservation[4];
        protected string name, ID, contact;
        protected char memberShip; // R : regular, M : member
        protected double totalFee;

        protected static bool luckyDraw = false; 
        /*Based on system required ,
         lucky Draw only exists for more than 3 reservetion made a member customer.
         So initialzed as FALSE as begin , if the reservetion more than 3 then become TRUE*/

       
        public Customer() { }

        public Customer(string n, string id, string ct, char ms)
        { 
            setName(n);
            setID(id);
            setContact(ct);
            setMemberShip(ms);
        }

        public void setName(string name)
        { this.name = name; }
        public string getName()
        { return this.name; }

        public void setID(string ID)
        { this.ID = ID; }
        public string getID()
        { return this.ID; }

        public void setContact(string contact)
        { this.contact = contact; }
        public string getContact()
        { return this.contact; }

        public void setMemberShip(char memberShip)
        { this.memberShip = memberShip; }
        public char getMemberShip()
        { return this.memberShip; }

        public abstract void addReserveList(Reservation reserve);

        public abstract double calTotalFee();
    }
}
