using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    class AirCraft 
    {
        protected string planeCode, origin, destination, departTime, arriveTime;
        protected double prices = 0;

        public AirCraft() { }
        public AirCraft(string code, string ori, string des, string dTime, string ATime,double prices) 
        { 
            setPlaneCode(code);
            setOrigin(ori);
            setDestination(des);
            setArriveTime(dTime);
            setDepartTIme(ATime);
            setPrices(prices);
        }

        public void setPlaneCode(string planeCode) 
        { this.planeCode = planeCode; }
        public string getPlaneCode()
        { return this.planeCode; }

        public void setOrigin(string origin)
        { this.origin = origin; }
        public string getOrigin()
        { return this.origin; }

        public void setDestination(string destination)
        { this.destination = destination; }
        public string getDestination()
        { return this.destination; }

        public void setDepartTIme(string departTime)
        { this.departTime = departTime; }
        public string getDepartTIme()
        { return this.departTime; }

        public void setArriveTime(string arriveTime)
        { this.arriveTime = arriveTime; }
        public string getArriveTime()
        { return this.arriveTime; }

        public void setPrices(double prices)
        { this.prices = prices; }
        public double getPrices()
        { return this.prices; }
    }
}
