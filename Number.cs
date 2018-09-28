using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Number
    {
        private int num;
        public  void setNumber(int num)
        {
            this.num = num;
        }

        public void getNumber()
        {
            Console.WriteLine("The number is {0}",num);
        }
    }
}
