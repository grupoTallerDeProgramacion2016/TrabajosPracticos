using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i+ ": "+ fibo(i));
            }

            Console.ReadLine();
        }
        
        static int fibo (int num)
        {
            if (num < 2)
            {
                return 1;
            }else 
            return fibo(num - 1) + fibo(num -2);
        }
    }
}
