using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6.Tests
{
    [TestClass()]
    public class OrderItemTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            OrderItem orderItem1 = new OrderItem(10, 10, "cup");
            OrderItem orderItem2 = new OrderItem(10, 10, "cup");
            OrderItem orderItem3 = new OrderItem(10, 5, "cup");
            OrderItem orderItem4 = new OrderItem(10, 10, "chair");
            Assert.IsTrue(orderItem1.Equals(orderItem2));
            Assert.IsFalse(orderItem1.Equals(orderItem3));
            Assert.IsFalse(orderItem1.Equals(orderItem4));
        }

        [TestMethod()]
        public void ToStringTest()
        {
            OrderItem orderItem1 = new OrderItem(10, 10, "cup");
            Assert.AreEqual(" name of item:cup unit price:10 number of items:10\n", orderItem1.ToString());
        }
    }
}