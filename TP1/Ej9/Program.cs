using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i =35; i <= 1977; i++)
            {
                if (esPrimo(i))
                {
                    sum += i;
                    Console.WriteLine(i);
                }
                
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
        static Boolean esPrimo(int n) {
        int a=0;
            for (int i=2;i<n;i++){
                if(n%i==0){
                a++;
                }
            }
        if(a>0){
                return false;
        }else{
                return true;
         }
          
        }
    }
}
