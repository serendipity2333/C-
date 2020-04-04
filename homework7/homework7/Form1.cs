using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel1.CreateGraphics();
            graphics.Clear(Color.White);
            double th1, th2, leng;
            double per1 = ((double)trackBarPer1.Value) / 10;
            double per2 = ((double)trackBarPer2.Value) / 10;
            double th = -Math.PI / 2;
            string color = (string)colorComboBox.SelectedItem;
            if (!Double.TryParse(textBoxTh1.Text,out th1)||!Double.TryParse(textBoxTh2.Text,out th2)||!Double.TryParse(textBoxLeng.Text,out leng))
            {
                MessageBox.Show("输入错误,请重新输入！", "ERROR");
                return;
            }
            th1 = th1 * Math.PI / 180;
            th2 = th2 * Math.PI / 180;
            drawCayleyTree(listBoxN.SelectedIndex+1, panel1.Width/2, panel1.Height-10, leng, th, th1, th2, per1, per2, color);
        }

        void drawCayleyTree(int n, double x0, double y0, double leng,double th,double th1,double th2,double per1,double per2,string color)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1,color);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1, th1, th2, per1, per2,color);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2, th1, th2, per1, per2,color);
        }

        void drawLine(double x0,double y0,double x1,double y1,string color)
        {
            //graphics = panel1.CreateGraphics();
            Pen pen;
            switch (color)
            {
                case "红色":
                    pen = new Pen(Color.Red);
                    break;
                case "蓝色":
                    pen = new Pen(Color.Blue);
                    break;
                case "绿色":
                    pen = new Pen(Color.Green);
                    break;
                default:
                    pen = new Pen(Color.Black);
                    break;
            }
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
