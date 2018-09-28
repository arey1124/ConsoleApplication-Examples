using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp1
{
    class EmployeeNew
    {
        public int id { get; set; }
        public string ename { get; set; }
        public string job { get; set; }
        public int salary { get; set; }

        private List<EmployeeNew> employees;

        public void AddEmployee(EmployeeNew e)
        {
            this.employees.Add(e);
        }

        public void displayNames()
        {
            var query = from data in employees select data.ename;

           foreach(string name in query)
            {
                Console.WriteLine("{0}",name);
            }
        }
        public void DeleteEmployee(int id)
        {
            for (var i = 0; i < employees.Count(); i++)
            {
                if (employees[i].id == id)
                {
                    employees.Remove(employees[i]);
                }
            }
            
        }

        public void SearchEmployee(int id)
        {
            foreach (EmployeeNew e1 in employees)
            {
                if (e1.id == id)
                {
                    Console.WriteLine("{0} , {1} , {2} , {3}", e1.id, e1.ename, e1.job, e1.salary);
                }
            }
        }
        
        public void UpdateEmployee(int id,EmployeeNew e)
        {
            for(int i = 0; i < employees.Count(); i++)
            {
                if (employees[i].id == id)
                {
                    employees[i] = e;
                }
            }
        }

        public List<EmployeeNew> GetEmployees()
        {
            employees = new List<EmployeeNew>()
                {
                    new EmployeeNew { id = 1, ename = "Ariha", job = "SE", salary = 55000 },
                    new EmployeeNew { id = 2, ename = "Chaya", job = "P", salary = 54000 },
                    new EmployeeNew { id = 3, ename = "Prash", job = "SE", salary = 53000 },
                    new EmployeeNew { id = 4, ename = "Kir", job = "P", salary = 52000 },
                    new EmployeeNew { id = 5, ename = "A", job = "SE", salary = 51000 },
                    new EmployeeNew { id = 6, ename = "B", job = "P", salary = 50000 },
                    new EmployeeNew { id = 7, ename = "C", job = "SE", salary = 51000 },
                    new EmployeeNew { id = 8, ename = "D", job = "P", salary = 58000 },
                    new EmployeeNew { id = 9, ename = "E", job = "SE", salary = 59000 },
                    new EmployeeNew { id = 10, ename = "F", job = "P", salary = 42000 },
                    new EmployeeNew { id = 11, ename = "G", job = "SE", salary = 32000 },
                    new EmployeeNew { id = 12, ename = "H", job = "P", salary = 2000 },
                    new EmployeeNew { id = 13, ename = "I", job = "SE", salary = 12000 },
                    new EmployeeNew { id = 14, ename = "J", job = "SE", salary = 22000 },
                    new EmployeeNew { id = 15, ename = "K", job = "P", salary = 32000 }

                };
            return employees;
        }

        


    }
}
