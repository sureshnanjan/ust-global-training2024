using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    /// <summary>
    /// Test class for Delegate
    /// </summary>
    [TestClass]
    public class Test_Delegate
    {
        /// <summary>
        /// Test method of Sum using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateSum()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            AddNum SumOfNum = new AddNum(delegateDemo.Add);
            int actual = SumOfNum(12, 2);
            int expected = 14;
            Equals(expected, SumOfNum);
        }

        /// <summary>
        /// Test method of Product using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateProduct()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            Product ProdOfNum = new Product(delegateDemo.Mutliply);
            int actual = ProdOfNum(12, 2);
            int expected = 24;
            Equals(expected, ProdOfNum);
        }

    }
}
