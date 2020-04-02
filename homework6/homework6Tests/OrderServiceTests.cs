using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void InquireOrderTest()
        {
            OrderService service = new OrderService();
            Order order = new Order("s001", "Bob");
            service.AddOrder(order);
            Assert.IsTrue(service.InquireOrder("s001"));
            Assert.IsFalse(service.InquireOrder("s002"));
        }

        [TestMethod()]
        public void OrderIncludeItemTest()
        {
            OrderService service = new OrderService();
            Order order = new Order("s001", "Bob");
            order.AddItem(10, 10, "cup");
            service.AddOrder(order);
            Assert.IsTrue(service.OrderIncludeItem("cup"));
            Assert.IsFalse(service.OrderIncludeItem("chair"));
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService service = new OrderService();
            Order order1 = new Order("s001", "Bob");
            Order order2 = new Order("s002", "Allen");
            order1.AddItem(10, 10, "cup");
            order2.AddItem(10, 5, "table");
            service.AddOrder(order1);
            service.AddOrder(order2);
            Assert.IsTrue(service.DeleteOrder("s002"));
            Assert.IsFalse(service.DeleteOrder("s003"));
            Assert.IsFalse(service.InquireOrder("s002"));
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            OrderService service = new OrderService();
            Order order1 = new Order("s001", "Bob");
            order1.AddItem(10, 10, "cup");
            service.AddOrder(order1);
            string s = "order number:s001 order's client:Bob total price:100\n name of item:cup unit price:10 number of items:10\n";
            Assert.AreEqual(s, service.orders[0].ToString());
            Assert.IsFalse(service.AddOrder(order1));
        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderService service = new OrderService();
            String file = "temp.xml";
            service.Export(file);
            Assert.IsTrue(File.Exists(file));
            List<String> expectLines = File.ReadLines("expectedOrders.xml").ToList();
            List<String> outputLines = File.ReadLines(file).ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService service = new OrderService();
            service.Import("otherorders.xml");
            Order order = new Order("James", "s006");
            Assert.AreEqual(1, service.orders.Count);
        }
    }

}