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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }
        internal OrderDetatils od = new OrderDetatils
        {
            OrderNumber = OrderService.list.Count + 1,
            OrderQuantity = 0,
            ProductName = "PRNAME",
            Client = "CLIENT"
        };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                od.OrderQuantity = int.Parse(this.textBox1.Text);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text != "")
            {
                od.ProductName = (this.textBox1.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox3.Text != "")
            {
                od.Client = (this.textBox1.Text);
            }
        }
    }
}
