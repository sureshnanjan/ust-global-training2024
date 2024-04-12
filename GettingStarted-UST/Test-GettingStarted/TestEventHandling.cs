using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    /// <summary>
    /// Sample class to explain the process of Food Order handling in hotel
    /// </summary>

    [TestClass]
    public class TestEventHandling
    {
        /// <summary>
        /// Event handling test case to validate the Order management in Hotel
        /// </summary>
        [TestMethod]
        public void eventHandling()
        {
            Kitchen kfc = new Kitchen(); // Publisher
            Waiter waiter1 = new Waiter(1); // Consumers
            Waiter waiter2 = new Waiter(2);
            
            Cashier cashier = new Cashier(1);
            Customer cu1 = new Customer("Gopi");
            Customer cu2 = new Customer("Suresh");
            

            kfc.PlaceOrder(cu1.OrderFood);
            kfc.PlaceOrder(waiter1.ServeFood);
            kfc.PlaceOrder(cu1.BillPayment);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PlaceOrder(cu2.OrderFood);
            kfc.PlaceOrder(waiter2.ServeFood);
            kfc.PlaceOrder(cu2.BillPayment);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PrepareTheFood();
            Assert.AreEqual(cu1.notification, "Gopi is ordering the Food");
            Assert.AreEqual(waiter1.notification, "Waiter 1 is Serving the Food");
            Assert.AreEqual(cu1.notification2, "Gopi is Paying the Bill");
            Assert.AreEqual(cashier.notification, "Cashier 1 is collecting the Money");
            Assert.AreEqual(cu2.notification, "Suresh is ordering the Food");
            Assert.AreEqual(waiter2.notification, "Waiter 2 is Serving the Food");
            Assert.AreEqual(cu2.notification2, "Suresh is Paying the Bill");
            Assert.AreEqual(cashier.notification, "Cashier 1 is collecting the Money");
        }
    }
}
