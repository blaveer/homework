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
    public partial class NewOrders : Form
    {
        public int Num = 0;
        public bool OK = false;
        public NewOrders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Num = int.Parse(this.textBox1.Text);
                this.OK = true;
                SucessScene sucessScene = new SucessScene();
                sucessScene.ShowDialog();
                //sucessScene.Shown()
                Thread.Sleep(1500);
                
                this.Close();
            }
            catch(Exception ex)
            {
                ErrorScene errorScene = new ErrorScene();
                errorScene.ShowDialog();
            }
           
        }
    }
}
