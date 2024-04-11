using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestEventHandler
    {
        [TestMethod]
        public void eventHandling()
        {
            Kitchen kfc = new Kitchen(); // Publisher
            Waiter waiter1 = new Waiter(1); // Consumers
            Waiter waiter2 = new Waiter(2);

            Cashier cashier = new Cashier(1);
            Customer customer1 = new Customer("test1");
            Customer customer2 = new Customer("test2");


            kfc.PlaceOrder(customer1.OrderFood);
            kfc.PlaceOrder(waiter1.ServeFood);
            kfc.PlaceOrder(customer1.BillPayment);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PlaceOrder(customer2.OrderFood);
            kfc.PlaceOrder(waiter2.ServeFood);
            kfc.PlaceOrder(customer2.BillPayment);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PrepareTheFood();
            Assert.AreEqual(customer1.notification, "test1 is ordering the Food");
            Assert.AreEqual(waiter1.notification, "Waiter 1 is Serving the Food");
            Assert.AreEqual(customer1.notification2, "test1 is Paying the Bill");
            Assert.AreEqual(cashier.notification, "Cashier 1 is collecting the Money");
            Assert.AreEqual(customer2.notification, "test2 is ordering the Food");
            Assert.AreEqual(waiter2.notification, "Waiter 2 is Serving the Food");
            Assert.AreEqual(customer2.notification2, "test2 is Paying the Bill");
            Assert.AreEqual(cashier.notification, "Cashier 1 is collecting the Money");
        }
    }
}
