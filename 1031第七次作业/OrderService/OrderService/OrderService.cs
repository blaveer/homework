using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService
{
    internal class OrderService:Order
    {
        public static int NumOfOrder = 0;                                     //设计生成订单的数量
        public static int LengOfOrder = list.Count;                            //订单的本身的长度
        public bool CreateOrder()                                             //在订单后面单独生成一个订单
        {
            int i = list.Count + 1;
            AddOrder(i);
            return true;
        }
        public bool CreateOrderS(int num,bool auto)                            //按照数量生成订单
        {
            if (auto)
            {
                for(int i = 1; i < num + 1; i++)
                {
                    AddOrder(i);
                }
                return true;
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    AddOrder();
                }
                return false;
            }
        }
       /* public bool ChangeOrder(int i)
        {

        }*/
        public bool OutputOrder(List<OrderDetatils> list1)                     //输出订单        
        {
            Console.WriteLine("order as follows:");      //输出订单
            Console.WriteLine("共有" + list.Count + "个订单");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine("订单号码： " + list1[i].OrderNumber);
                Console.WriteLine("订单数量： " + list1[i].OrderQuantity);
                Console.WriteLine("商品名称： " + list1[i].ProductName);
                Console.WriteLine("客户名字： " + list1[i].Client);
                Console.WriteLine();
            }
            return true;
        }
        public bool FindByOrderName(int num)                           //按照订单号查询订单
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
                    return true;
                }
            }
            return false;
        }
        public bool FindByOrderQuantity(int num)                      //按照订单数量来查询订单
        {
            Console.WriteLine("Please enter the order quantity you want to see:");
            //int num = int.Parse(Console.ReadLine());
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
                    return true;
                }
            }
            return false;

        }
        public bool FindByProductName(string num)                          //按照商品名称查询订单
        {
            Console.WriteLine("Please enter the product name you want to see:");
            //string num = Console.ReadLine();
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
                    return true;
                }
            }
            return false;
        }
        public bool FindByClientName(string num)                             //按照客户查询订单
        {
            Console.WriteLine("Please enter the client name you want to see:");
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
                    return true;
                }
            }
            return false;
        }

        internal class Student
        {
        }
    }
}
