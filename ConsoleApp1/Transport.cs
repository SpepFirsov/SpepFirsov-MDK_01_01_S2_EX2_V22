using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Transport
    {
        private string name;
        private string appointment;
        private int appr_price;

        public string Appointment { get => appointment; set => appointment = value; }
        public int Appr_Price { get => appr_price; set => appr_price = value; }
        public string Name { get => name; set => name = value; }
        
        public Transport()
        {
    
        }

        public Transport(string name, string appointment, int appr_price)
        {
            this.name = name;
            this.appointment = appointment;
            this.appr_price = appr_price;

        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Название транспорта:" + name);
            Console.WriteLine("Назначение транспорта:" + appointment);
            Console.WriteLine("Приблизительная цена транспорта:" + appr_price);
        }

    }
}
