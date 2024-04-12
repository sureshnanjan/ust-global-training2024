using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class Test_EventHandler
    {
        /// <summary>
        /// Food ordering examples using Event handling methods
        /// </summary>
        [TestMethod]
        public void eventHandling()
        {
            Kitchen kfc = new Kitchen(); // Publisher
            Waiter waiter1 = new Waiter(1); // Consumers
            Waiter waiter2 = new Waiter(2);

            Cashier cashier = new Cashier(1);
            Customer cu1 = new Customer("Lechu");
            Customer cu2 = new Customer("Unni");


            kfc.PlaceOrder(cu1.OrderFood);
            kfc.PlaceOrder(waiter1.ServeFood);
            kfc.PlaceOrder(cu1.BillPayment);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PlaceOrder(cu2.OrderFood);
            kfc.PlaceOrder(waiter2.ServeFood);
            kfc.PlaceOrder(cu2.BillPayment);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PrepareTheFood();
            Assert.AreEqual(cu1.notification, "Lechu is ordering the Food");
            Assert.AreEqual(waiter1.notification, "Waiter 1 is Serving the Food");
            Assert.AreEqual(cu1.notification2, "Lechu is Paying the Bill");
            Assert.AreEqual(cashier.notification, "Cashier 1 is collecting the Money");
            Assert.AreEqual(cu2.notification, "Unni is ordering the Food");
            Assert.AreEqual(waiter2.notification, "Waiter 2 is Serving the Food");
            Assert.AreEqual(cu2.notification2, "Unni is Paying the Bill");
            Assert.AreEqual(cashier.notification, "Cashier 1 is collecting the Money");
        }

    }
}