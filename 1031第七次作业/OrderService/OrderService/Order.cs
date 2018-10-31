using System;
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
                orderDetatils.OrderNumber = i;
                orderDetatils.OrderQuantity = i * i + i * i * i + i * i * i * i;
                orderDetatils.ProductName = GenerateCheckCode(i);
                orderDetatils.Client = GenerateCheckCode(i * i + 1);
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
    }
}
