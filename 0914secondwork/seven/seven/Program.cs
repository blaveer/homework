 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            int ave = 0;
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            ave = sum / array.Length;
            Console.WriteLine("数组的最大值为：" + max);
            Console.WriteLine("数组的最小值为：" + min);
            Console.WriteLine("数组的平均值为：" + ave);
            Console.WriteLine("数组的和为：" + sum);
        }
      

    }
}
