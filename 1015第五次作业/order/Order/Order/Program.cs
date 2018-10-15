using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderManagement
{
    // 写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单
    //(按照订单号、商品名称、客户等字段进行查询）功能。在订单删除、修改失败时，
    //能够产生异常并显示给客户错误信息。
    //提示：需要写Order（订单）、OrderDetails（订单明细），OrderService（订单服务）几个类，
    //订单数据可以保存在OrderService中一个List中。

    //订单明细
    public class OrderDetatils
    {
        public int OrderNumber { get; set; }           //订单号
        public int OrderQuantity { get; set; }         //订单数量     //订单金额
        public string ProductName { get; set; }        //商品名称 
        public string Client { get; set; }             //客户
    }
    public class Order
    {
        public static List<OrderDetatils> list = new List<OrderDetatils>();    //没有将list设置为static的，所以会多一个函数后面
        public static void AddOrder()
        {
            OrderDetatils orderDetatils = new OrderDetatils();

            try
            {
                Console.WriteLine("Please enter the order number:");
                orderDetatils.OrderNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the order quantity:");
                orderDetatils.OrderQuantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the product name:");
                orderDetatils.ProductName = Console.ReadLine();
                Console.WriteLine("Please enter the client name:");
                orderDetatils.Client = Console.ReadLine();
                list.Add(orderDetatils);
            }
            catch
            {
                Console.WriteLine("The date you entered is invaild!!!");
            }

        }
    }
    class OrderService : Order
    {
        static void Main(string[] arg)
        {
            
            Console.WriteLine("Please enter the sum of order:");
            int sum = int.Parse(Console.ReadLine());
            for (int i = 1; i < sum + 1; i++)
            {
                Console.WriteLine("请输入第" + i + "个订单的详细信息：");
                AddOrder();     //添加订单

            }
            OutputOrder();                               //输出订单


            Console.WriteLine("Please enter the product name you want to see:");
            string num = Console.ReadLine();
            var m1 = from n in list where n.ProductName.Equals(num) select n;
            foreach (var n in m1)
            {
                Console.WriteLine("商品名称为" + num + "的订单如下" );
                FindByOrderName(n.OrderNumber);                     
            }

            Console.WriteLine("Please enter the client name you want to see:");
            string numOfClient = Console.ReadLine();
            var m2 = from n in list where n.Client.Equals(numOfClient) select n;
            foreach (var n in m2)
            {
                Console.WriteLine("客户名称为" + numOfClient + "的订单如下");
                FindByOrderName(n.OrderNumber);
            }

            var m3 = from n in list where n.OrderQuantity > 10000 select n;
            Console.WriteLine("订单数量（金额）大于10000的订单如下");
            foreach (var n in m3)
            {
               
                FindByOrderName(n.OrderNumber);
            }


        }
        static void OutputOrder()
        {
            Console.WriteLine("order as follows:");      //输出订单
            Console.WriteLine("共有" + list.Count + "个订单");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("订单号：" + list[i].OrderNumber);
                Console.WriteLine("订单数量：" + list[i].OrderQuantity);
                Console.WriteLine("商品名称：" + list[i].ProductName);
                Console.WriteLine("客户：" + list[i].Client);
                Console.WriteLine();
            }
        }
        
       
        static void FindByOrderName(int num)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].OrderNumber == num)
                {
                    //Console.WriteLine("第" + i+1 + "个订单的详细信息如下：");
                    Console.WriteLine("订单号：" + list[i].OrderNumber);
                    Console.WriteLine("订单数量：" + list[i].OrderQuantity);
                    Console.WriteLine("商品名称：" + list[i].ProductName);
                    Console.WriteLine("客户：" + list[i].Client);
                    Console.WriteLine();
                    break;
                }
            }
        }
        static void FindByOrderQuantity()
        {
            Console.WriteLine("Please enter the order quantity you want to see:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].OrderQuantity == num)
                {
                    Console.WriteLine("第" + i + "个订单的详细信息如下：");
                    Console.WriteLine("订单号：" + list[i].OrderNumber);
                    Console.WriteLine("订单数量：" + list[i].OrderQuantity);
                    Console.WriteLine("商品名称：" + list[i].ProductName);
                    Console.WriteLine("客户：" + list[i].Client);
                    Console.WriteLine();
                    break;
                }
            }

        }
        static void FindByProductName()
        {
            Console.WriteLine("Please enter the product name you want to see:");
            string num = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductName.Equals(num))
                {
                    Console.WriteLine("第" + i + "个订单的详细信息如下：");
                    Console.WriteLine("订单号：" + list[i].OrderNumber);
                    Console.WriteLine("订单数量：" + list[i].OrderQuantity);
                    Console.WriteLine("商品名称：" + list[i].ProductName);
                    Console.WriteLine("客户：" + list[i].Client);
                    Console.WriteLine();
                    break;
                }
            }
        }
        static void FindByClientName()
        {
            Console.WriteLine("Please enter the client name you want to see:");
            string num = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Client.Equals(num))
                {
                    Console.WriteLine("第" + i + "个订单的详细信息如下：");
                    Console.WriteLine("订单号：" + list[i].OrderNumber);
                    Console.WriteLine("订单数量：" + list[i].OrderQuantity);
                    Console.WriteLine("商品名称：" + list[i].ProductName);
                    Console.WriteLine("客户：" + list[i].Client);
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
