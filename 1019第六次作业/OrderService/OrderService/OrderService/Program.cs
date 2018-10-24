using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace orderManagement
{
    public class OrderDetatils
    {
        public int OrderNumber { get; set; }           //订单号
        public int OrderQuantity { get; set; }         //订单数量     //订单金额
        public string ProductName { get; set; }        //商品名称 
        public string Client { get; set; }             //客户
    }
    public class Order
    {
        public static List<OrderDetatils> list = new List<OrderDetatils>();
        public static bool AddOrder(int i)
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

      

        static string GenerateCheckCode(int codeCount)
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
   public  class OrderService : Order
    {
        static void Main(string[] arg)                                                                    //主函数
        {

            Console.WriteLine("Please enter the sum of order:");
            string s0 = Console.ReadLine();
            int sum = 0;
            if (!s0.Equals(""))
            {
                sum = int.Parse(s0);
            }
            for (int i = 1; i < sum + 1; i++)
            {
                AddOrder(i);     //添加订单

            }
            XmlWrite();
            XmlRead();
            OutputOrder(list);                               //输出订单




        }
        public static bool XmlWrite()
        {
            XmlSerializer serializer = new XmlSerializer(list.GetType());
            TextWriter writer = new StreamWriter("List.xml");
            serializer.Serialize(writer, list);
            writer.Close();
            return true;
        }
        public static bool XmlRead()
        {
            XmlSerializer serializer = new XmlSerializer(list.GetType());
            FileStream stream = new FileStream("List.xml", FileMode.Open);
            List<OrderDetatils> list1 = (List<OrderDetatils>)serializer.Deserialize(stream);
            OutputOrder(list1);
            stream.Close();
            return true;
        }
        public static bool OutputOrder(List<OrderDetatils> list1)
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
        public static bool FindByOrderName(int num)
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
        public static bool FindByOrderQuantity(int num)
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
        public static bool FindByProductName(string num)
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
        public static bool FindByClientName(string num)
        {
            Console.WriteLine("Please enter the client name you want to see:");
            //string num = Console.ReadLine();
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
    }
}
