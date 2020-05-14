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
    public partial class FormAdd : Form
    {
        public Order order = new Order();
        public FormAdd()
        {
            InitializeComponent();
            
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] priceList = { 10, 30, 100, 20 };
            labelPrice.Text = priceList[comboBoxName.SelectedIndex].ToString();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(labelPrice.Text);
            int number = 0;
            if(!Int32.TryParse(textBoxNumber.Text, out number))
            {
                MessageBox.Show("输入数量有误！");
                return;
            }

            order.AddItem(price, number, comboBoxName.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            if (textBoxClient.Text == ""||textBoxID.Text==""||textBoxID.Text[0]!='s')
            {
                MessageBox.Show("客户名或编号有误！");
                return;
            }

            order.Client = textBoxClient.Text;
            order.OrderNo = textBoxID.Text;

            foreach (var i in form1.orders)
            {
                if (i.Equals(order))
                {
                    MessageBox.Show("当前要添加的订单已存在！");
                    return;
                }
            }
            using (var db = new OrderContext())
            {
                db.orders.Add(order);
                db.SaveChanges();
            }
            form1.orders.Add(order);
            using (var db = new OrderContext())
            {
                db.orders.Add(order);
                db.SaveChanges();
            }
                form1.reLoad();
            this.Close();
        }
    }
}
