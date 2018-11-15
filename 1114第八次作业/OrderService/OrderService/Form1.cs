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
            //if (this.textBox1.Text != "")
            //{
            //    try
            //    {
            //        _number = int.Parse(this.textBox1.Text);
            //    }
            //    catch
            //    {
            //        this.textBox1.Text = "输入有误！！！";
            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)  //查询订单数量
        {
            SeeOrderNum seeOrder = new SeeOrderNum
            {
                Location = new System.Drawing.Point(200,400)
            };
            seeOrder.ShowDialog();

            //seeOrder.label1.Text = OrderService.list.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e) //新增订单
        {
            NewOrderOne newOrder = new NewOrderOne();
            newOrder.ShowDialog();
            if (newOrder.OK)
            {
                OrderDetatils order = new OrderDetatils
                {
                    OrderNumber = Order.NumToString(OrderService.list.Count + 1),
                    OrderQuantity = newOrder.od.OrderQuantity,
                    ProductName = newOrder.od.ProductName,
                    Client = newOrder.od.Client
                };
                _orderService.AddOrder(order);

            }         
        }

        private void button3_Click(object sender, EventArgs e)     //修改订单
        {
            try
            {
                ChangeOrder changeOrder = new ChangeOrder();

                changeOrder.ShowDialog();
                if (changeOrder.OK)
                {
                    OrderService.list[changeOrder.Num - 1].OrderQuantity = changeOrder.cOrder.OrderQuantity;
                    OrderService.list[changeOrder.Num - 1].ProductName = changeOrder.cOrder.ProductName;
                    OrderService.list[changeOrder.Num - 1].Client = changeOrder.cOrder.Client;
                    //_orderService.AddOrder(changeOrder.cOrder);
                }
            }catch(Exception ex)
            {
                ErrorScene errorScene = new ErrorScene();
                errorScene.ShowDialog();
            }
            //if (!this.textBox2.Text.Equals("输入有误！！！"))
            //{
            //    NewOrder newOrder = new NewOrder();
            //    newOrder.ShowDialog();
            //    OrderService.list[_number - 1].OrderQuantity = newOrder.od.OrderQuantity;
            //    OrderService.list[_number - 1].ProductName = newOrder.od.ProductName;
            //}
            
        }

        private void button4_Click(object sender, EventArgs e)      //生成订单
        {
            NewOrders newOrders = new NewOrders();
            newOrders.ShowDialog();
            if (newOrders.OK)
            {
                _orderService.CreateOrderS(newOrders.Num, true);
            }
        }

        private void button5_Click(object sender, EventArgs e)    //数据绑定  查询订单
        {
            SawOrder saw = new SawOrder();
            saw.ShowDialog();
            /*Inquire inquire = new Inquire();
            inquire.ShowDialog();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // toolTip1.SetToolTip(textBox1, "请输入");
            toolTip1.SetToolTip(button5, "请点击数据绑定查询订单");
            toolTip1.SetToolTip(button1, "请点击查询订单数量");
            toolTip1.SetToolTip(button2, "点击新增订单");
            toolTip1.SetToolTip(button3, "点击修改订单");
            toolTip1.SetToolTip(button4, "点击生成一定数量的订单");
            toolTip1.SetToolTip(button6, "点击生成HTML文件");
            toolTip1.SetToolTip(button7, "点击检验订单信息");
            //toolTip1.SetToolTip(button6_Click, "chgvhb");
        }

        private void button6_Click(object sender, EventArgs e)    //XML to HTML
        {
            XML xML = new XML();
            xML.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckOrder checkOrder = new CheckOrder();
            checkOrder.ShowDialog();
        }
    }
}
