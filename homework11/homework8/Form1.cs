using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace homework11
{
    public partial class Form1 : Form
    {
        public List<Order> orders = new List<Order>();
        public Form1()
        {
            using (var db = new OrderContext())
            {
                var query = db.orders.Where(b => b.OrderNo != "");
                foreach(var i in query)
                {
                    orders.Add(i);
                }
            }
                InitializeComponent();
                bindingSourceOrders.DataSource = orders;
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.Text = "添加订单";
            formAdd.Owner = this;
            formAdd.Show();
           
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            FormDelete formDelete = new FormDelete();
            formDelete.Text = "删除订单";
            formDelete.Owner = this;
            formDelete.Show();
        }

        private void buttonChangeOrder_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
           
            FormChange formChange = new FormChange(orders[a]);
            formChange.Text = "修改订单";
            formChange.Owner = this;
            formChange.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyWords = textBoxInquire.Text;
            if(keyWords=="")
            {
                reLoad();
            }
            bindingSourceOrders.DataSource = orders.Where(order => order.OrderNo == keyWords);
            bindingSourceOrders.ResetBindings(false);
        }
        
        
        public void reLoad()
        {
            this.bindingSourceOrders.DataSource = orders;
            this.bindingSourceOrders.ResetBindings(false);
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            int selectIndex = dataGridView1.CurrentRow.Index;
            //dataGridView2.DataSource = bindingSourceDetails;
            bindingSourceDetails.DataSource = dataGridView1.SelectedRows;
            */
            Order order = bindingSourceOrders.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            bindingSourceDetails.DataSource = order.orderDetail;
            bindingSourceDetails.ResetBindings(false);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                Export(fileName);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                Import(fileName);
                reLoad();
            }
        }


        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }
    }
}
