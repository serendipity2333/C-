using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11
{
    [Serializable]
    public class Order : IComparable
    {
        [Key]
        public string OrderNo { get; set; }
        public string Client { get; set; }
        public int TotalPrice { get; set; }
        public List<OrderItem> orderDetail = new List<OrderItem>();

        public Order()
        {
            OrderNo = "";
            Client = "";
            TotalPrice = 0;
        }

        public Order(string n, string c)
        {
            OrderNo = n;
            Client = c;
            TotalPrice = 0;
        }
        //添加明细
        public bool AddItem(int m, int num, string name)
        {
            OrderItem item = new OrderItem(m, num, name);
            foreach (var i in orderDetail)
            {
                if (i.Equals(item))
                {
                    //Console.WriteLine("该订单明细已存在！");
                    return false;
                }
            }
            orderDetail.Add(item);
            TotalPrice += item.ItemNumber * item.SingleMoney;
            //Console.WriteLine("添加明细成功！");
            return true;
        }

        

        public override string ToString()
        {
            string str = "";
            foreach (var i in orderDetail)
                str += i.ToString();
            return "order number:" + OrderNo + " order's client:" + Client + " total price:" + TotalPrice + "\n" + str;
        }

        public int CompareTo(object obj)
        {
            Order rec = obj as Order;
            if (rec == null)
                throw new System.ArgumentException();
            return this.OrderNo.CompareTo(rec.OrderNo);
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   OrderNo == order.OrderNo &&
                   Client == order.Client &&
                   TotalPrice == order.TotalPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = -1380644702;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderNo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Client);
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(orderDetail);
            return hashCode;
        }
    }
}
