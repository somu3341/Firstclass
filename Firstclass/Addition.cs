using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstclass
{
    internal class Addition
    {
        static int a = 10;
        static int b = 20;
        static int c = (a+b);
        static void Main(string[] args)
        {            
            Console.WriteLine("addition of a and b is " +c);
        }
  
    }
}
