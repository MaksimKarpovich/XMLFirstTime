using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFirstTime
{
    /// <summary>
    /// Класс, описывающий элемент машина
    /// </summary>
    internal class Car
    {
        public Motor Motor;
        public Chassis Chassis;
        public Transmission Transmission;

        public Car(Motor Motor, Chassis Chassis, Transmission Transmission) 
        {
            this.Motor = Motor;
            this.Chassis = Chassis;
            this.Transmission = Transmission;
        }

        public void Info() 
        {
            this.Motor.Info();
            this.Chassis.Info();
            this.Transmission.Info();
        }


    }
}
