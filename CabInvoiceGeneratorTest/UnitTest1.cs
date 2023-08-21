using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        InvoiceService invoiceService = new InvoiceService();
        [Test]
        public void GivenDistanceAndTime_WhenChecked_ReturnTotalFare()
        {
            double actual = invoiceService.CalculateFare(10, 5);
            int expected = 105;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenRides_WhenChecked_ReturnTotalFare()
        {
            Ride[] rides =
            {
                new Ride(){Distance=10,Time=5}
            };
            double actual = invoiceService.CalculateFare(rides);
            double expexted = 105;
            Assert.AreEqual(actual, expexted);
        }
        [Test]
        public void GivenRides_WhenChecked_ReturnTotalRides()
        {
            Ride[] rides =
            {
                new Ride(){Distance=10,Time=5}
            };
            invoiceService.CalculateFare(rides);
            int actual = invoiceService.TotalNumOfRides();
            double expexted = rides.Length;
            Assert.AreEqual(actual, expexted);
        }
    }
}