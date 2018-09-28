using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Marks
    {
        private string name;
        private int marks1, marks2, marks3, total;
        private float avg;

        public void setMarks(string name,int marks1,int marks2,int marks3)
        {
            this.name = name;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;
        }

        public void calculate()
        {
            avg = (marks1 + marks2 + marks3) / 3;
            total = marks1 + marks2 + marks3;
        }

        public void getMarks()
        {
            Console.WriteLine("The Student is : {0}",name);
            Console.WriteLine("The marks are : {0},{1},{2}",this.marks1,this.marks2,this.marks3);
            Console.WriteLine("The average is : {0}",avg);
            Console.WriteLine("The total is : {0}",total);
        }
    }
}
