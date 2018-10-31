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
    public partial class Inquire : Form
    {
       
        public string keyWord { get; set; }
        public int KeyWord { get; set; }
        //private OrderDetatils _orderDetatils = new OrderDetatils();
        //internal List<OrderDetatils> list1 = new List<OrderDetatils>();

        public Inquire()
        {
            InitializeComponent();
            //list1.Add(new OrderDetatils(1,11,"11","11"));
            //list1.Add(new OrderDetatils(2, 22, "22", "22"));
            //list1.Add(new OrderDetatils(3, 33, "33", "33"));
            //list1.Add(new OrderDetatils(4, 44, "44", "44"));
            //list1.Add(new OrderDetatils(5, 55, "55", "55"));
            //list1.Add(new OrderDetatils(6, 66, "66", "66"));
            //list1.Add(new OrderDetatils(7, 77, "77", "77"));
            orderBindingSource.DataSource = OrderService.list;
            //orderBindingSource.DataSource = students;
            //绑定查询条件
            queryInput.DataBindings.Add("Text",this, "keyWord");
            //orderDetailsBindingSource.DataSource = order[0].list;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeyWord = int.Parse(keyWord);
            orderBindingSource.DataSource =
                      OrderService.list.Where(s => s.OrderNumber == KeyWord);
        }

        private void queryInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
