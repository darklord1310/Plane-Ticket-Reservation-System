using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    class Reservation
    {
        protected Trips trip = new Trips();
        protected string TripType; // single :  singleTrip ,return : return Trip
        protected Customer customer;
        public Reservation() { }
        public Reservation(Trips t, Customer cust, string type)
        {
            setTrip(t);
            setCust(cust); 
            setTripType(type);
        }

        public void setTrip( Trips trip)
        { this.trip = trip; }
        public Trips getTrip()
        { return this.trip; }

        public void setCust(Customer cust)
        { customer = cust; }
        public Customer getCust()
        { return customer; }


        public void setTripType( string type)
        { TripType = type; }
        public double calFee()
        {
            double fee = trip.getTotalCharge();

            if (TripType.Equals("return"))
                return fee * 2;
            else return fee;
        }
    }
}

