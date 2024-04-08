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
        [TestMethod]
        public void eventHandling()
        {
            Kitchen kfc = new Kitchen(); // Publisher
            Waiter waiter1 = new Waiter(1); // Consumers
            Waiter waiter2 = new Waiter(2);
            Waiter waiter3 = new Waiter(3);
            Cashier cashier = new Cashier(1);
            Customer cu1 = new Customer("Gopi");
            Customer cu2 = new Customer("Suresh");
            Customer cu3 = new Customer("UST");

            kfc.PlaceOrder(cu1.OrderFood);
            kfc.PlaceOrder(waiter1.ServeFood);
            kfc.PlaceOrder(cu1.BillPayment);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PlaceOrder(cu2.OrderFood);
            kfc.PlaceOrder(waiter2.ServeFood);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PlaceOrder(cu3.OrderFood);
            kfc.PlaceOrder(waiter3.ServeFood);
            kfc.PlaceOrder(cashier.CollectMoney);
            kfc.PrepareTheFood();

        }
    }
}
