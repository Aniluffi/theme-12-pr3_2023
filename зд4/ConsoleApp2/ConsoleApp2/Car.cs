using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Car
    {
        string marka;
        string model;
        int number;

        public Car(string marka, string model, int number)
        {
            this.marka = marka;
            this.model = model;
            this.number = number;
        }

        public void Start ()
        {
            Console.WriteLine($"Машина Mersedes 600 завелась");
        }

        public void Stop()
        {
            Console.WriteLine($"Машина Mersedes 600 остановилась");
        }
    }
}
