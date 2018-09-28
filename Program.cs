using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Child;
using System.Threading;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class FoodItems{
        public int id { get; set; }
        public int calories { get; set; }
        public int price { get; set; }
        public string itemName { get; set; }

        public List<FoodItems> items = new List<FoodItems>();
        public FoodItems()
        {
            GetFoodItems();
        }
        public FoodItems(int id, int calories , int price , string itemName)
        {
            this.id = id;
            this.calories = calories;
            this.price = price;
            this.itemName = itemName;
        }



        public List<FoodItems> GetFoodItems()
        {
            this.items.Add(new FoodItems(id = 1, calories = 200, price = 50, itemName = "Dosa"));
            this.items.Add(new FoodItems(id = 2, calories = 100, price = 30, itemName = "Idly"));
            return items;
        }
    }

    class Orders : FoodItems
    {
        private int id, qty;
        private FoodItems item;
        public Orders(int id, int qty) : base()
        {
            this.qty = qty;
            item = this.items.Find(x => x.id == id);
        }

        public void getBill()
        {
            Console.WriteLine("The food item is {0}",this.item.itemName);
            Console.WriteLine("The price is {0}",this.item.price);
            Console.WriteLine("The amount to be paid is {0}",(this.item.price*this.qty));
        }
    }
    
    class Parent
    {
        public int age;
        public string name;
        public Parent(string name,int age)
        {
            this.name = name;
            this.age = age;

        }
        public virtual void display()
        {
            Console.WriteLine("Parent name is {0} and age is {1}",this.name,this.age);
        }
    }

    class Son : Parent
    {
        
        public Son(string name, int age) : base(name,age)
        {
           
        }
        public override void display()
        {
            Console.WriteLine("Child name is {0} and age is {1}", this.name, this.age);
        }
    }


    class Program
    {
        static void display()
        {
            string[] girls = { "Neha", "Mahima", "Harsha", "Megha" };
            for(int i = 0; i < girls.Length; i++)
            {
                Console.WriteLine( "{0} : {1}", Thread.CurrentThread.Name, girls[i]);
                Thread.Sleep(500);
            }
        }

        static void display2()
        {
            string[] boys = { "Amit", "Sankalp", "Prajjwal", "Chayank" };
            for (int i = 0; i < boys.Length; i++)
            {
                Console.WriteLine("{0} : {1}",Thread.CurrentThread.Name, boys[i]);
                Thread.Sleep(500);
            }
        }
        
        static void Main(string[] args)
        {

            //EmployeeNew e = new EmployeeNew();
            //List<EmployeeNew> emp = e.GetEmployees().Take(3).ToList();

            //Child1 c = new Child1();
            //c.display();
            //c.displayBase();


            //Orders o1 = new Orders(1,2);
            //o1.getBill();

            //Orders o2 = new Orders(2, 5);
            //o2.getBill();

            //Parent a = new Parent("Prajjwal",21);
            //a.display();

            //a = new Son("Sachin",21);
            //a.display();

            //Thread t = new Thread(display);
            //t.Name = "Girls Thread  ";
            //Thread t2 = new Thread(display2);
            //t2.Name = "Boys Thread  ";

            //t.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Lowest;

            //t.Start();
            //t2.Start();

            String cs = "server=USER-PC;user id=sa;pwd=1234;database=StpDB;";
            SqlConnection sqlConnection = new SqlConnection(cs);
            sqlConnection.Open();
            Console.WriteLine("Established");
            sqlConnection.Close();
            Console.WriteLine("Closed");



            Console.ReadKey();
        }
    }
}
