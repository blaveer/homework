﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService
{
    class Order
    {
        public static List<OrderDetatils> list = new List<OrderDetatils>();    //list用来存储订单
         
        public bool AddOrder()                                                 //生成一个订单，手动输入订单的各项信息
        {
            OrderDetatils orderDetatils = new OrderDetatils();

            try
            {
                Console.WriteLine("Please enter the order number:");
                orderDetatils.OrderNumber = (Console.ReadLine());
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
                return false;
            }
            return true;
        }

        public bool AddOrder(OrderDetatils order)
        {
            list.Add(order);
            return true;
        }

        public bool AddOrder(int i)                                     //随机生成一个订单，依据传入的int数据自动生成各项信息
        {
            OrderDetatils orderDetatils = new OrderDetatils();
            try
            {
                orderDetatils.OrderNumber = NumToString(i);
                orderDetatils.OrderQuantity = GenerateCheckOrderQuantityCode(i);
                orderDetatils.ProductName = GenerateCheckCode(i);
                orderDetatils.Client = GenerateCheckNumberCode(i * i + 1);
                list.Add(orderDetatils);

            }
            catch
            {
                Console.WriteLine("The date you entered is invaild!!!");
            }
            return true;
        }                       

        string GenerateCheckCode(int codeCount)                          //随机生成一个长度为6的字符串，依据传入的int值来控制范围
        {
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + codeCount;
            codeCount++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> codeCount)));
            for (int i = 0; i < 6; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }
            return str;
        }
        string GenerateCheckNumberCode(int codeCount)          //返回一个长度为7，的纯数字字符串
        {
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + codeCount;
            codeCount++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> codeCount)));
            for (int i = 0; i < 4; i++)
            {
                char ch;
                int num = random.Next();
                ch = (char)(0x30 + ((ushort)(num % 10)));
                str = str + ch.ToString();
            }
            str = str + '-';
            for (int i = 0; i < 3; i++)
            {
                char ch;
                int num = random.Next();
                ch = (char)(0x30 + ((ushort)(num % 10)));
                str = str + ch.ToString();
            }
            return str;
        }
        public static string NumToString(int i)             //为订单号确定符合要求的字符串
        {
            string str = string.Empty;
            if (i>=0&&i < 10)
            {
                str = DateTime.Now.ToShortDateString() + "/00" + i.ToString();
            }
            else if (i >= 10 && i < 100)
            {
                str = DateTime.Now.ToShortDateString() + "/0" + i.ToString();
            }
            else if (i >= 100 && i < 1000)
            {
                str = DateTime.Now.ToShortDateString() + "/" + i.ToString();
            }
            else
            {
                str = DateTime.Now.ToShortDateString() + "/" + 999.ToString();
            }
            return str;
        }
        int GenerateCheckOrderQuantityCode(int codeCount)          //返回一个长度不大于4的数字
        {
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + codeCount;
            codeCount++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> codeCount)));
            for (int i = 0; i < 4; i++)
            {
                char ch;
                int num = random.Next();
                ch = (char)(0x30 + ((ushort)(num % 10)));
                str = str + ch.ToString();
            }
            return int.Parse(str);
        }
    }
}
