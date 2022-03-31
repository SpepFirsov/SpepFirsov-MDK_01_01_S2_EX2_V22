using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car : Automobile
    {
        private int number_of_pass;

        public Car(int number_of_pass, string material, string engine, int mileage, int speed, string name, string appointment, int appr_price) : base(material, engine, mileage, speed, name, appointment, appr_price)
        {
            this.number_of_pass = number_of_pass;
        }

        public override void GetInfo()
        {
            
            base.GetInfo();
            Console.WriteLine("Макс количество пассажиров в автомобиле " + number_of_pass);
        }
    }
}