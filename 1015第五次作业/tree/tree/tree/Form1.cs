using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tree
{
    public partial class Form1 : Form
    {
        //NUM num = new NUM();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                graphics = this.CreateGraphics();
            }
            drawCayleyTree(10, 300, 350, 100, -Math.PI / 2);
        }
        private Graphics graphics;
        
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0)
            {
                return;
            }
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1,y1, NUM.per1 * leng, th + NUM.th1);
            drawCayleyTree(n - 1, x1 - leng * Math.Cos(th) * NUM.k, y1 - leng * Math.Sin(th) * NUM.k, NUM.per2 * leng, th - NUM.th2);
        }
        void drawLine(double x0,double y0, double x1, double y1)
        {
            try
            {
                graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
            }
            catch (OverflowException)
            {
                Font myFont = new Font("宋体", 60, FontStyle.Bold);
                Brush bush = new SolidBrush(Color.Red);//填充的颜色
                graphics.DrawString("溢出了", myFont, bush, 150, 130);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            NUM.k = hScrollBar1.Value*1.0/(hScrollBar1.Maximum -hScrollBar1.Minimum);
           // NUM.k = 0.3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.textBox1.Attributes.Add("onkeydown", "keyDown(" + this.Button1.ClientID + ");");
            textBox1.Font = new Font("宋体", 14, textBox1.Font.Style);
            if (textBox1.Text != "")
            {
                NUM.th1 = double.Parse(textBox1.Text) * Math.PI / 180; 

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Font = new Font("宋体", 14, textBox1.Font.Style);
            if (textBox2.Text != "")
            {
                NUM.th2 = double.Parse(textBox2.Text) * Math.PI / 180;
            }
               
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Font = new Font("宋体", 14, textBox1.Font.Style);
            if (textBox3.Text != "")
            {
                NUM.per1 = double.Parse(textBox2.Text);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Font = new Font("宋体", 14, textBox1.Font.Style);
            if (textBox4.Text != "")
            {
                NUM.per2 = double.Parse(textBox2.Text);
            }
        }
    }
    class NUM
    {
        public static double th1 = 30 * Math.PI / 180;
        public static double th2 = 20 * Math.PI / 180;
        public static double per1 = 0.6;
        public static double per2 = 0.7;
        public static double k = 0.0;
    }
}
