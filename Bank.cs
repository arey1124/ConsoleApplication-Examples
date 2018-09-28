using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Bank
    {
        private static int id_gen;
        private int  id = 0 ;
        private string name;
        private int depositAmount,accountBalance;

        public Bank(string name,int depositAmount)
        {
            this.id = ++Bank.id_gen;
            this.name = name;
            this.depositAmount = depositAmount;
            this.accountBalance += depositAmount;

            if(Convert.ToString(DateTime.Now.DayOfWeek) == "Tuesday")
            {
                this.accountBalance += 1000;
            }else if( Convert.ToString(DateTime.Now.DayOfWeek) == "Sunday" || Convert.ToString(DateTime.Now.DayOfWeek) == "Saturday")
            {
                this.accountBalance += 500;
            }
        }

        public void deposit(int depositAmount)
        {
            Console.WriteLine("Attempt: Deposit amount of Rs: {0}",depositAmount);
            int current_time = Convert.ToInt32(DateTime.Now.Hour);
            Thread.Sleep(3000);
            if (Convert.ToString(DateTime.Now.DayOfWeek) == "Sunday" || Convert.ToString(DateTime.Now.DayOfWeek) == "Saturday")
            {
                Console.WriteLine("Deposit not allowed on weekends");
            }
            else if ((current_time >= 10 && current_time <= 14) || (current_time >= 16 && current_time <= 18))
            {
                Console.WriteLine("Deposit not allowed at this time");
            }
            else if (depositAmount > 50000)
            {
                Console.WriteLine("Deposit amount cannot exceed 50,000 . Please contact the manager ");
            }
            else
            {
                this.accountBalance += depositAmount - 1;
                Console.WriteLine("Amount deposited successfully");
            }
        }

        public void getDetails()
        {
            Console.WriteLine("{0} {1} {2}", id , name , accountBalance);
        }
    }
}
