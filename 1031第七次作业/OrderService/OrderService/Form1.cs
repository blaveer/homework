using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private OrderService _orderService = new OrderService();
        private int _number = 1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                try
                {
                    _number = int.Parse(this.textBox1.Text);
                }
                catch
                {
                    this.textBox1.Text = "输入有误！！！";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeeOrder seeOrder = new SeeOrder
            {
                Location = new System.Drawing.Point(200,400)
            };
            seeOrder.ShowDialog();

            //seeOrder.label1.Text = OrderService.list.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            newOrder.ShowDialog();
            OrderDetatils order = new OrderDetatils
            {
                OrderNumber = OrderService.list.Count + 1,
                OrderQuantity =newOrder.od.OrderQuantity,
                ProductName = newOrder.od.ProductName,
                Client = newOrder.od.Client
            };
            _orderService.AddOrder(order);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text != "")
            {
                try
                {
                    _number = int.Parse(this.textBox2.Text);
                }
                catch
                {
                    this.textBox2.Text = "输入有误！！！";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!this.textBox2.Text.Equals("输入有误！！！"))
            {
                NewOrder newOrder = new NewOrder();
                newOrder.ShowDialog();
                OrderService.list[_number - 1].OrderQuantity = newOrder.od.OrderQuantity;
                OrderService.list[_number - 1].ProductName = newOrder.od.ProductName;
                OrderService.list[_number - 1].Client = newOrder.od.Client;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!this.textBox1.Text.Equals("输入有误！！！"))
            {
                _orderService.CreateOrderS(_number, true);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inquire inquire = new Inquire();
            inquire.ShowDialog();
        }
    }
}
