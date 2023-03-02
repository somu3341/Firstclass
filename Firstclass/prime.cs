using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Firstclass
{
    internal class prime
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                for(int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        Console.WriteLine("It is not a prime number" + i);
                        break;
                    }            
                }
                Console.WriteLine("It is a prime" + i);
            }
        }
    }
}
