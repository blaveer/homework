using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要做质数分解的数：");
            int com = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}的质因数分解为：", com);
            Console.Write(com + "=");
            for(int i = 2; i < com; i++)
            {
                while (com != i)
                {
                    if(com % i == 0)
                    {
                        Console.Write(i + "x");
                        com = com / i;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(com);
        }
       //public void Prime()
       // {
            
       // }
    }
}
