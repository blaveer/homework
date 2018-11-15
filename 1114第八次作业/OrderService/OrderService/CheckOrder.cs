using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderService
{
    public partial class CheckOrder : Form
    {
        public List<OrderDetatils> ErrorOrder = new List<OrderDetatils>();
        //public List<Errores> ErrorOrder = new List<Errores>();
        public CheckOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OrderN = "[0-9]{4}/[0-9]{2}/[0-9]{2}/[0-9]{3}";
            int Count = 0;
 
            for (int i = 0;i< OrderService.list.Count; i++)
            {
                string s = OrderService.list[i].OrderNumber;
                if(Regex.IsMatch(s, OrderN))
                {
                    Count++;
                }
                else
                {
                    ErrorOrder.Add(OrderService.list[i]);
                    //ErrorOrder[ErrorOrder.Count-1].
                }
            }
            if (Count == OrderService.list.Count)
            {
                SucessScene sucessScene = new SucessScene();
                sucessScene.ShowDialog();
            }
            else
            {
                ErrorScene errorScene = new ErrorScene();
                errorScene.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Count = 0;
            for (int i = 0; i < OrderService.list.Count; i++)
            {
                int iOrder = OrderService.list[i].OrderQuantity;
                if (iOrder < 10000)
                {
                    Count++;
                }
                else
                {
                    ErrorOrder.Add(OrderService.list[i]);
                }
            }
            if (Count == OrderService.list.Count)
            {
                SucessScene sucessScene = new SucessScene();
                sucessScene.ShowDialog();
            }
            else
            {
                ErrorScene errorScene = new ErrorScene();
                errorScene.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int CountOfI = 0;
            for(int i = 0; i < OrderService.list.Count; i++)
            {
                int CountOfJ = 0;
                for(int j = i + 1; j < OrderService.list.Count; j++)
                {
                    if (!OrderService.list[i].OrderNumber.Equals(OrderService.list[j].OrderNumber))
                    {
                        CountOfJ++;
                    }
                }
                if ((i + CountOfJ + 1) == OrderService.list.Count)
                {
                    CountOfI++;
                }
            }
            if (CountOfI == OrderService.list.Count)
            {
                SucessScene sucessScene = new SucessScene();
                sucessScene.ShowDialog();
            }
            else
            {
                ErrorScene errorScene = new ErrorScene();
                errorScene.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string OrderC = "[0-9]{4}-[0-9]{3}";
            int Count = 0;
            for (int i = 0; i < OrderService.list.Count; i++)
            {
                string s = OrderService.list[i].Client;
                if (Regex.IsMatch(s, OrderC))
                {
                    Count++;
                }
                else
                {
                    ErrorOrder.Add(OrderService.list[i]);
                    //ErrorOrder[ErrorOrder.Count-1].
                }
            }
            if (Count == OrderService.list.Count)
            {
                SucessScene sucessScene = new SucessScene();
                sucessScene.ShowDialog();
            }
            else
            {
                ErrorScene errorScene = new ErrorScene();
                errorScene.ShowDialog();
            }
        }

        private void CheckOrder_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "点击检验订单号码");
            toolTip1.SetToolTip(button2, "点击检验订单数量");
            toolTip1.SetToolTip(button3, "点击检验订单号码是否重复");
            toolTip1.SetToolTip(button4, "点击检验客户号码");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

     
    }
    public class Errores
    {
        public OrderDetatils order;
        public enum Error
        {
            OrderNumber, 
            OrderQuantity,
            ProductName, 
            Client 
        }
        public Errores(OrderDetatils order)
        {
            this.order = order;           
        }
    }
}
