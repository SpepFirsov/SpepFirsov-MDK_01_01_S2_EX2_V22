using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Truck : Automobile
    {
        private int capacity;

        public Truck(int capacity, string material, string engine, int mileage, int speed, string name, string appointment, int appr_price) : base(material, engine, mileage, speed, name, appointment, appr_price)
        {
            this.capacity = capacity;

        }


        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Грузовая вместимость:" + capacity);
        }
    }
}