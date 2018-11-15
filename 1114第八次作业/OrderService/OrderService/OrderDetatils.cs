using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService
{
    public class OrderDetatils
    {
        //DateTime.Now.ToShortDateString();
        public string OrderNumber { get; set; }           //订单号
        public int OrderQuantity { get; set; }         //订单数量     //订单金额
        public string ProductName { get; set; }        //商品名称 
        public string Client { get; set; }             //客户
        public OrderDetatils(string OrderNumber,int OrderQuantity,string ProductName,string Client)
        {
            this.OrderNumber = OrderNumber;
            this.OrderQuantity = OrderQuantity;
            this.ProductName = ProductName;
            this.Client = Client;
        }
        public OrderDetatils()
        {

        }
    }
}
