using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Numbers
    {
        private int num1, num2;

        public void setNumbers(int num1 , int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void getNumbers()
        {
            Console.WriteLine("Number 1 is : {0}",num1);
            Console.WriteLine("Number 2 is : {0}",num2);
        }
    }
}
