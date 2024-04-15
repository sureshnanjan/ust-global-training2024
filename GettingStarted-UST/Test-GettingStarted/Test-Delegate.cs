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
        /// Test method of Sum of positive integers using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateSumOfPositiveNumbers()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            AddNum SumOfNum = new AddNum(delegateDemo.Add);
            int actual = SumOfNum(12, 2);
            int expected = 14;
            Equals(expected, SumOfNum);
        }

        /// <summary>
        /// Test method of Sum of negative integers using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateSumOfNegativeNumbers()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            AddNum SumOfNum = new AddNum(delegateDemo.Add);
            int actual = SumOfNum(-12, -2);
            int expected = -14;
            Equals(expected, SumOfNum);
        }

        /// <summary>
        /// Test method of Sum of Postive and Negative using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateSumOfPositiveAndNegativeNumbers()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            AddNum SumOfNum = new AddNum(delegateDemo.Add);
            int actual = SumOfNum(12, -2);
            int expected = 10;
            Equals(expected, SumOfNum);
        }

        /// <summary>
        /// Test method of Sum of Negative and Postive integers using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateSumOfNegativeAndPositiveNumbers()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            AddNum SumOfNum = new AddNum(delegateDemo.Add);
            int actual = SumOfNum(-12, 2);
            int expected = -10;
            Equals(expected, SumOfNum);
        }

        /// <summary>
        /// Test method of Product of Postive Integers using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateProductOfPositiveNumbers()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            Product ProdOfNum = new Product(delegateDemo.Mutliply);
            int actual = ProdOfNum(12, 2);
            int expected = 24;
            Equals(expected, ProdOfNum);
        }

        /// <summary>
        /// Test method of Product of Negative integers using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateProductOfNegativeNumbers()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            Product ProdOfNum = new Product(delegateDemo.Mutliply);
            int actual = ProdOfNum(-12, -2);
            int expected = 24;
            Equals(expected, ProdOfNum);
        }

        /// <summary>
        /// Test method of Product of Positive & Negative integers using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateProductOfPositiveAndNegativeNumbers()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            Product ProdOfNum = new Product(delegateDemo.Mutliply);
            int actual = ProdOfNum(12, -2);
            int expected = -24;
            Equals(expected, ProdOfNum);
        }

        /// <summary>
        /// Test method of Product of Negative & Postive integers using delegate
        /// </summary>
        [TestMethod]
        public void TestForUsageOfDelegateProductOfNegativeAndPositiveNumbers()
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            Product ProdOfNum = new Product(delegateDemo.Mutliply);
            int actual = ProdOfNum(-12, 2);
            int expected = -24;
            Equals(expected, ProdOfNum);
        }

    }
}
