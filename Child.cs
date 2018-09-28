using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Child : Base
    {
        public void display()
        {
            Console.WriteLine("Inside Child Class : {0} , {1}", b, c);
        }
    }
}
