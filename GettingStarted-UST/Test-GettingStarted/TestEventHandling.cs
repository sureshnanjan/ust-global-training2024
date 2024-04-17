using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestEventHandling
    {

        [TestMethod]
        public void RaiseEvent()
        {
            Kitchen kfc = new Kitchen();

            Cook cook1 = new Cook("kfc103", "Biriyani", "Cook1", 001);
            /*Waiter waiter1 = new Waiter(001, "Biriyani", "kfc103");
            Cashier cashier1 = new Cashier("C001");*/
            kfc.PlaceOrder(cook1.PrepareFood);
            kfc.CollectOrder();
            bool actual = cook1.Equals("Cook1 is starting preparation of order kfc103");
            bool expected = false;
            //Console.WriteLine($"{cook1.PrepareFood}");
            Assert.IsTrue(actual);
        }

    }
}
