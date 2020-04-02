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
    public class OrderTests
    {
        [TestMethod()]
        public void AddItemTest()
        {
            Order order1 = new Order("s001", "Bob");
            order1.AddItem(10, 10, "cup");
            OrderItem item = new OrderItem(10, 10, "cup");
            Assert.IsTrue(order1.orderDetail[0].Equals(item));
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Order order1 = new Order("s001", "Bob");
            order1.AddItem(10, 10, "cup");
            order1.AddItem(20, 10, "chair");
            string s = "order number:s001 order's client:Bob total price:300\n name of item:cup unit price:10 number of items:10\n name of item:chair unit price:20 number of items:10\n";
            Assert.AreEqual(s, order1.ToString());
        }


        [TestMethod()]
        public void CompareToTest()
        {
            Order order1 = new Order("s001", "Bob");
            Order order2 = new Order("s002", "Bob");
            Order order3 = new Order("s003", "James");
            Assert.IsTrue(order2.CompareTo(order1) > 0);
            Assert.IsTrue(order3.CompareTo(order1) > 0);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Order order1 = new Order("s001", "Bob");
            order1.AddItem(20, 10, "chair");

            Order order2 = new Order("s001", "Bob");
            order2.AddItem(20, 10, "chair");

            Order order3 = new Order("s001", "Bob");

            //Assert.IsTrue(order1.Equals(order2));
            Assert.IsFalse(order1.Equals(order3));
        }
    }
}