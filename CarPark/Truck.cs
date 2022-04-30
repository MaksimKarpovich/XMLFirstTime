using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFirstTime
{
    internal class Truck : Car
    {
        public double CarryingCapacity = 0;

        public Truck(Motor Motor, Chassis Chassis, Transmission Transmission, double CarryingCapacity) : base(Motor, Chassis, Transmission)
        {
            if (CarryingCapacity > 0)
            {
                this.CarryingCapacity = CarryingCapacity;
            }
            else { Console.WriteLine("Введено некорректное значение грузоподъёмности."); }
        }

        public void Info()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Параметры грузовика:");
            if (this.CarryingCapacity != 0)
            {
                Console.WriteLine("\tГрузоподъёмность \t" + this.CarryingCapacity + "\n");
            }
            else { Console.WriteLine("Введено некорректное значение зрузоподъёмности."); }
            base.Info();
            Console.WriteLine("----------------------------------------------");
        }
    }
}
