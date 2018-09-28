using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Base
    {
        private int a = 100;
        public int b = 200;
        protected int c = 300;

        public void displayBase()
        {
            Console.WriteLine("Inside Base Class : {0} , {1} , {2}", a, b, c);
        }
    }
}
