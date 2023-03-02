using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstclass
{
    internal class Greatest
    {
        static int a=5; static int b=8; static int c=9; 
        static void Main(string[] args)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("a is greater " + a);
            }         
                else if (b > c && b > a)
            {
                Console.WriteLine("b is greater " + b);
            }                
                else
                Console.WriteLine("c is greater " + c);
        }
    }
}
