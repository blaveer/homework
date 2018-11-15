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
    public partial class ChangeOrder : Form
    {
        public bool OK = false;
        public OrderDetatils cOrder;
        public int Num = 0;
        public ChangeOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OK = true;
                Num = int.Parse(this.textBox1.Text);
                cOrder = new OrderDetatils
                {
                    OrderNumber = Order.NumToString(Num),
                    OrderQuantity = int.Parse(this.textBox2.Text),
                    ProductName = this.textBox3.Text,
                    Client = this.textBox4.Text
                };
            }
            catch(Exception ex)
            {
                ErrorScene errorScene = new ErrorScene();
                errorScene.ShowDialog();
            }
            
        }
    }
}
