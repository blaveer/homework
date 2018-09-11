using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入两个数：");
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("{0}和{1}的乘积是{2}", c, d, c * d);
                System.Threading.Thread.Sleep(10 * 100000000);
                // Console.ReadLine();
            }
        }
    }
}
