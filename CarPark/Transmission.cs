using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFirstTime
{
    /// <summary>
    /// Класс, описывающий элемент трансмиссии
    /// </summary>
    internal class Transmission
    {
        public string Type = "";
        public int NumberOfGears = 0;
        public string Creater = "";

        public Transmission(string Type, int NumberOfGears, string Creater) 
        {
            if (NumberOfGears > 0)
            {
                this.NumberOfGears = NumberOfGears;
            }
            else { Console.WriteLine("Введено некорректное значение количества передач."); }

            this.Type = Type;
            this.Creater = Creater;
        }

        public void Info()
        {
            if (this.NumberOfGears != 0 && this.Type != "" && this.Creater != "")
            {
                Console.WriteLine("Параметры трансмиссии:");
                Console.WriteLine("\tТип \t\t\t" + this.Type);
                Console.WriteLine("\tКоличество передач \t" + this.NumberOfGears);
                Console.WriteLine("\tпроизводитель \t\t" + this.Creater + "\n");
            }
            else { Console.WriteLine("Неверно введены параметры трансмиссии.\n"); }
        }
    }
}
