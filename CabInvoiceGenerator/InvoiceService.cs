using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceService
    {
        private const int MIN_FARE = 5;
        private const int COST_PER_MIN = 1;
        private const double COST_PER_KM=10;

        public double CalculateFare(double distance,double time)
        {
            double totalAmount = distance*COST_PER_KM + time * COST_PER_MIN;
            if(totalAmount > MIN_FARE )
            {
                return totalAmount;
            }
            return MIN_FARE;
        }
        public double CalculateFare(Ride[] rides)
        {
            double totalAmount = 0;
            foreach (var ride in rides)
            {
                totalAmount += ride.Distance * COST_PER_KM + ride.Time * COST_PER_MIN;
            }
            int numOfRides = rides.Length;
            double aggregateAmount = totalAmount / numOfRides;
            return aggregateAmount;

        }
    }
}
