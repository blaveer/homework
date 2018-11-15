using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderService
{
    public partial class NewOrderOne : Form
    {
        public bool OK = false;
        public NewOrderOne()
        {
            InitializeComponent();
            this.button1.Text = "生成一个新订单";
        }
        internal OrderDetatils od = new OrderDetatils
        {
            OrderNumber = DateTime.Now.ToShortDateString()+ (OrderService.list.Count + 1).ToString(),
            OrderQuantity = 0,
            ProductName = "PRNAME",
            Client = "CLIENT"
        };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox1.Text != "")
            //{
            //    od.OrderQuantity = int.Parse(this.textBox1.Text);
            //}

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox2.Text != "")
            //{
            //    od.ProductName = (this.textBox1.Text);
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (this.textBox3.Text != "")
            //{
            //    od.Client = (this.textBox1.Text);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                od.OrderQuantity = int.Parse(this.textBox1.Text);
                od.ProductName = (this.textBox1.Text);
                od.Client = (this.textBox1.Text);
                OK = true;
                this.button1.Text = "操作成功";
                for(int i = 3; i > 0; i--)
                {
                    Thread.Sleep(1000);
                    this.button1.Text = "此页面将在" + i + "秒钟关闭";
                }
                this.Close();
            }
            catch(Exception ex)
            {
                ErrorScene errorScene = new ErrorScene();
                errorScene.ShowDialog();
            }
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "请输入订单数量");
            toolTip1.SetToolTip(textBox2, "请输入订单名称");
            toolTip1.SetToolTip(textBox3, "请输入客户名称");
            toolTip1.SetToolTip(button1, "请点击确认生成");
        }
    }
}
