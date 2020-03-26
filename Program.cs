using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            Order order1 = new Order("s001", "Bob");
            order1.AddItem(10, 10, "cup");
            order1.AddItem(20, 10, "chair");
            order1.AddItem(100, 1, "table");
            //重复添加
            order1.AddItem(10, 10, "cup");
            Order order2 = new Order("s002", "Allen");
            order2.AddItem(100, 2, "table");
            Order order3 = new Order("s003", "Allen");
            order3.AddItem(20, 10, "chair");
            service.AddOrder(order2);
            service.AddOrder(order3);
            service.AddOrder(order1);
            //重复添加
            service.AddOrder(order3);
            service.ShowAll();
            //排序
            service.sortAsce();
            Console.WriteLine("排序后：");
            service.ShowAll();
            //查询编号为s001的订单
            service.InquireOrder("s001");
            //查询客户名为Bob的订单
            service.InquireOrder("Allen");
            //查询编号为s005的订单
            service.InquireOrder("s005");
            //查询包含table的订单
            service.OrderIncludeItem("table");
            //删除订单
            try
            {
                service.DeleteOrder("s002");
            }
            catch (InvalidOperationException e)
            {
                service.ShowAll();
            }
        }
    }
}
