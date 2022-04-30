using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFirstTime
{
    /// <summary>
    /// Класс, описывающий элемент двигатель
    /// </summary>
    internal class Motor
    {
        public double Power = 0;
        public double Volume = 0;
        public string Type = "";
        public string SerialNumer = "";

        public Motor(double Power, double Volume, string Type, string Serial) 
        {
            if (Power > 0)
            {
                this.Power = Power;
            }
            else { Console.WriteLine("Введено некорректное значение мощности двигателя."); }

            if (Volume > 0)
            {
                this.Volume = Volume;
            }
            else { Console.WriteLine("Введено некорректное значение объёма двигателя."); }

            this.Type = Type;
            this.SerialNumer = Serial;
        }

        public void Info()
        {
            if (this.Power != 0 && this.Volume != 0 && this.Type != "" && this.SerialNumer != "") 
            { 
                Console.WriteLine("Параметры двигателя:");
                Console.WriteLine("\tМощность \t\t" + this.Power);
                Console.WriteLine("\tОбъём \t\t\t" + this.Volume);
                Console.WriteLine("\tТип \t\t\t" + this.Type);
                Console.WriteLine("\tСерийный номер \t\t" + this.SerialNumer + "\n");
            }
            else { Console.WriteLine("Неверно введены параметры двигателя.\n"); }
        }
    }
}
