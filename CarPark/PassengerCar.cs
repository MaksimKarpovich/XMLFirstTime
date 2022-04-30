using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFirstTime
{
    internal class PassengerCar : Car
    {
        public int NumberSeats = 0;

        public PassengerCar(Motor Motor, Chassis Chassis, Transmission Transmission, int NumberSeats) : base(Motor, Chassis, Transmission)
        {
            if (NumberSeats > 0)
            {
                this.NumberSeats = NumberSeats;
            }
            else { Console.WriteLine("Введено некорректное значение числа сидений.");
            }
        }

        public void Info()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Параметры легкового автомобиля:");
            if (this.NumberSeats != 0)
            {
                Console.WriteLine("\tКоличество сидений \t" + this.NumberSeats + "\n");
            }
            else { Console.WriteLine("Введено некорректное значение числа сидений."); }
            base.Info();
            Console.WriteLine("----------------------------------------------");
        }
    }
}
