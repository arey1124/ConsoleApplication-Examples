using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MarksConsume
    {
        public static void Consume()
        {
            Marks m1 = new Marks();
            m1.setMarks("Arihant", 90, 90, 85);
            m1.calculate();
            m1.getMarks();

            Marks m2 = new Marks();
            m2.setMarks("Prajjwal" ,95, 80, 85);
            m2.calculate();
            m2.getMarks();

            Marks m3 = new Marks();
            m3.setMarks("Chayank", 99, 70, 65);
            m3.calculate();
            m3.getMarks();
        }
    }
}
