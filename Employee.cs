using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        private static int id_gen;
        private int salary,id;
        private string name, job;

        public Employee(string name , string job , int salary)
        {
            this.id = ++Employee.id_gen;
            this.name = name;
            this.job = job;
            this.salary = salary;
        }

        public void getDetails()
        {
            Console.WriteLine("{0} {1} {2} {3}",id,name,job,salary);
        }
    }
}
