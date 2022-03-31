using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Automobile : Transport
    {
        private string material;
        private string engine;
        private int mileage; //пробег автомобиля
        private int speed;

        public Automobile(string material, string engine, int mileage, int speed, string name, string appointment, int appr_price) : base(name, appointment, appr_price)
        {
            this.material = material;
            this.engine = engine;
            this.mileage = mileage;
            this.speed = speed;
        }
        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Материал автомобиля:" + material);
            Console.WriteLine("Двигатель автомобиля:" + engine);
            Console.WriteLine("Пробег автомобиля(за год):" + mileage);
            Console.WriteLine("Скорость автомобиля:" + speed + "км/ч");
        }


    }
}