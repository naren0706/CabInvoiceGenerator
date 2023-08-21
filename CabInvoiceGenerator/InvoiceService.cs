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
        private int totalNumberOfRides = 0;
        private double totalFare = 0;
        private double averageFare = 0;
        public int TotalNumOfRides()
        {
            return totalNumberOfRides;
        }
        public double TotalFare()
        {
            return totalFare;
        }
        public double AverageFare()
        {
            return averageFare; 
        }

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
            foreach (var ride in rides)
            {
                totalFare += (ride.Distance * COST_PER_KM + ride.Time * COST_PER_MIN);
            }
            totalNumberOfRides = rides.Length;
            averageFare = totalFare / totalNumberOfRides;
            return averageFare;

        }
    }
}
