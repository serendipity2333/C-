using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homework6
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        //查询订单
        public bool InquireOrder(string s)
        {
            var query = from order in orders
                        where order.OrderNo == s || order.Client == s
                        select order;
            List<Order> tempList = query.ToList();
            if (tempList.Count() == 0)
            {
                Console.WriteLine("未找到相应订单！");
                return false;
            }
            tempList.Sort((order1, order2) => { return order1.TotalPrice - order2.TotalPrice; });

            Console.WriteLine("您要查询的订单有：\n");
            foreach (var i in tempList)
            {
                Console.WriteLine(i.ToString());
            }
            return true;
        }
        //查询包含某商品的订单
        public bool OrderIncludeItem(string itemName)
        {
            bool haveItem = false;
            foreach (var order in orders)
            {
                var query = from i in order.orderDetail
                            where i.ItemName == itemName
                            select i;
                if (query.Count() != 0)
                {
                    haveItem = true;
                    Console.WriteLine("您要查询的订单有：\n" + order.ToString());
                }
            }
            if (!haveItem)
                Console.WriteLine("未找到包含相应商品的订单");
            return haveItem;
        }
        //删除订单
        public bool DeleteOrder(string orderNo)
        {
            bool flag = false;
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].OrderNo == orderNo)
                {
                    Console.WriteLine("已删除订单号为" + orders[i].OrderNo + "的订单");
                    orders.RemoveAt(i);
                    //Console.WriteLine("已删除订单号为" + i);
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("删除失败，未找到相应订单");
            }
            return flag;
        }
        //订单排序
        public void sortAsce()
        {
            orders.Sort();
        }
        //添加订单
        public bool AddOrder(Order newOrder)
        {
            foreach (var i in orders)
            {
                if (i.Equals(newOrder))
                {
                    Console.WriteLine("该订单已存在！");
                    return false;
                }
            }
            orders.Add(newOrder);
            Console.WriteLine("订单添加成功！");
            return true;
        }
        //展示当前所有订单
        public void ShowAll()
        {
            Console.WriteLine("当前所有订单：");
            foreach (var i in orders)
                Console.WriteLine(i);
        }
        //序列化为xml文件
        public void Export(string file)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                Order[] orderArr = orders.ToArray();
                xmlSerializer.Serialize(fs, orderArr);
            }
            Console.WriteLine("\nserialized as xml");
            Console.WriteLine(File.ReadAllText(file));
        }

        //读入xml文件
        public void Import(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    Order[] otherOrders = (Order[])xmlSerializer.Deserialize(fs);
                    orders.AddRange(otherOrders);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("当前目录下不存在该文件");
            }

        }
    }
}
