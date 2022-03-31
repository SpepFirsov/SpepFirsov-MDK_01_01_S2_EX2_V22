using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //public Car(int number_of_pass, string material, string engine, int mileage, int speed, string appointment, int price) : base(material, engine, mileage, speed, appointment, price)
        //public Truck(int capacity, string material, string engine, int mileage, int speed, string appointment, int price) : base(material, engine, mileage, speed, appointment, price)
        static void Main(string[] args)
        {

            Car bmw_c3 = new Car(4, "Сталь", "Дизель", 17500, 80, "BMW C3", "Передвижение по городу", 850000);
            Truck ZIL130 = new Truck(8, "Алюминий", "petrol", 320000, 90, "ZIL130", "Перевозка грузов", 120000);

            Console.WriteLine("Информация о авто 1");
            bmw_c3.GetInfo();
            Console.WriteLine("-------");
            Console.WriteLine("Информация о авто 2");
            ZIL130.GetInfo();
            Console.ReadLine();
        }
    }
}