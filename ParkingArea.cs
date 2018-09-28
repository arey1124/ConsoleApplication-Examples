using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum VehicleCategory
    {
        TwoWheeler,FourWheeler,HeavyVehicle
    }
    class ParkingArea
    {
        private int price, count;
        private VehicleCategory type;
        private string name;
        private int max_count = 50;

        public ParkingArea(VehicleCategory type , int count,string name)
        {
            this.type = type;
            this.count = count;
            this.name = name;

        }

        public void Move(ParkingArea c , int count)
        {
            if(this.type == c.type)
            {
                if((c.count + count) > max_count)
                {
                    c.count += (max_count - c.count);
                    this.count -= (max_count - c.count);
                    calculatePrice();
                }
                else
                {
                    c.count += count;
                    this.count -= count;
                    calculatePrice();
                }
            }
            else
            {
                Console.WriteLine("Cannot move as different type");
            }
            
        }

        public void BigCount(ParkingArea c)
        {
            if(this.count > c.count)
            {
                Console.WriteLine("{0} has more count than {1}",this.name,c.name);
            }
            else if( this.count < c.count)
            {
                Console.WriteLine("{0} has more count than {1}", c.name, this.name);
            }
            else
            {
                Console.WriteLine("{0} , {1} have the same count", this.name, c.name);
            }
        }

        private void calculatePrice()
        {
            if (type == VehicleCategory.TwoWheeler)
            {
                Console.WriteLine("The price is {0}", count * 10);
            }
            else if (type == VehicleCategory.FourWheeler)
            {
                Console.WriteLine("The price is {0}", count * 20);
            }
            else
            {
                Console.WriteLine("The price is {0}", count * 40);
            }
        }

        public void getPrice()
        {
            calculatePrice();
        }
    }
}
