using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11
{
    [Serializable]
    public class OrderItem
    {
        public Order order { get; set; }
        public string orderId { get; set; }
        public int SingleMoney { get; set; }
        public int ItemNumber { get; set; }
        [Key]
        public string ItemName { get; set; }

        public OrderItem()
        {
            SingleMoney = 0;
            ItemName = "";
            ItemNumber = 0;
        }

        public OrderItem(int m, int num, string name)
        {
            SingleMoney = m;
            ItemName = name;
            ItemNumber = num;
        }
        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            return item != null && item.ItemName == this.ItemName && item.ItemNumber == this.ItemNumber && item.SingleMoney == this.SingleMoney;
        }

        public override int GetHashCode()
        {
            var hashCode = -572172273;
            hashCode = hashCode * -1521134295 + SingleMoney.GetHashCode();
            hashCode = hashCode * -1521134295 + ItemNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ItemName);
            return hashCode;
        }
        public override string ToString()
        {
            return " name of item:" + ItemName + " unit price:" + SingleMoney + " number of items:" + ItemNumber + "\n";
        }
    }
}
