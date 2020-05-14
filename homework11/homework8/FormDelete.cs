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
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.Owner;
            bool haveTheOrder = false;
            for (int i = 0; i < parentForm.orders.Count; i++)
            {
                if (parentForm.orders[i].OrderNo == textBoxDelete.Text)
                {
                    //Console.WriteLine("已删除订单号为" + orders[i].OrderNo + "的订单");
                    parentForm.orders.RemoveAt(i);
                    using (var db = new OrderContext())
                    {
                        var tempOrder = db.orders.FirstOrDefault(p => p.OrderNo == textBoxDelete.Text);
                        if(tempOrder!=null)
                        {
                            db.orders.Remove(tempOrder);
                            db.SaveChanges();
                        }
                    }
                    haveTheOrder = true;
                }
            }
            if (!haveTheOrder)
            {
                label2.Text = "未找到相应订单！";
            }
            else
            {
                label2.Text = "删除成功!";
            }
            parentForm.reLoad();
            
        }
    }
}
