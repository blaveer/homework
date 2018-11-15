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
    public partial class SawOrder : Form
    {
        public string Num { get; set; }
        public SawOrder()
        {
            InitializeComponent();
            bindingSource1.DataSource= OrderService.list;
            textBox1.DataBindings.Add("text", this, "Num");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource =
                      OrderService.list.Where(s => s.OrderNumber.Equals(Num));
        }
    }
}
