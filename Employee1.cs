using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee1
    {
        public static void Consume()
        {
            Employee e = new Employee("Arihant", "Developer", 55000);
            Employee e1 = new Employee("Prajjwal", "Developer", 55000);
            Employee e2 = new Employee("Chayank", "Developer", 55000);

            e.getDetails();
            e1.getDetails();
            e2.getDetails();

        }
    }
}
