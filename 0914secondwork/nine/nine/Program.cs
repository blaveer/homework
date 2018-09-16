using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace nine
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] prime = new int[100];  
            bool[] isPrime = new bool[101];
            int numOfPrime = 0;
            for(int i = 0; i <= 100; i++)
            {
                isPrime[i] = true;
            }
            isPrime[0] = isPrime[1] = false;
            for(int i = 2; i <= 100; i++)
            {
                if (isPrime[i])
                {
                    prime[numOfPrime] = i;
                    numOfPrime++;
                    for(int j = 2 * i; j <= 100; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            Console.WriteLine("共有" + numOfPrime + "个素数。");
            Console.WriteLine("分别是：");
            for(int i = 1; i <= numOfPrime; i++)
            {
                Console.Write(prime[i-1] + "   ");
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
