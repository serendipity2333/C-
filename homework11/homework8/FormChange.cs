using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework11
{
   
    public partial class FormChange : Form
    {
        Dictionary<string, int> priceList = new Dictionary<string, int>();
        public Order order { get; set; }
        public OrderItem item;
        //int oldNumber;
        public FormChange(Order orderOld)
        {
            order = orderOld;
            //labelOrder.Text = "当前订单：" + order.OrderNo;
            priceList.Add("hat", 10);
            priceList.Add("chair", 30);
            priceList.Add("table", 100);
            priceList.Add("cup", 20);

            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int newNumber;
            if(!Int32.TryParse(textBoxNumber.Text, out newNumber))
            {
                MessageBox.Show("修改数量有误！");
                return;
            }
            
            bool haveItem = false;
            for (int i = 0;i<order.orderDetail.Count;i++)
            {
                if(order.orderDetail[i].ItemName == comboBoxOld.Text)
                {
                    haveItem = true;
                    using (var db = new OrderContext())
                    {
                        db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                        order.orderDetail[i].ItemName = comboBoxNew.Text;
                        order.orderDetail[i].ItemNumber = newNumber;
                        order.orderDetail[i].SingleMoney = priceList[comboBoxNew.Text];
                        db.SaveChanges();
                    }
                }
            }
            if(!haveItem)
            {
                MessageBox.Show("该订单不包含所选商品！");
                return;
            }
            order.TotalPrice = 0;
            foreach (var i in order.orderDetail)
            {
                order.TotalPrice += i.ItemNumber * i.SingleMoney;
            }
            Form1 mainForm = (Form1)this.Owner;
            mainForm.reLoad();
            this.Close();
        }

    }
}
