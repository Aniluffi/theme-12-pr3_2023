using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HowMin
    {
        public int hour;
        public int min;
        public int second;

        public HowMin(int min, int hour)
        {
            this.min = min;
            this.hour = hour;
        }

        public HowMin(int second,int min,int hour) : this(min, hour) 
            {
            this.second = second;
            }

        public HowMin()
        {

        }

        public void Inf ()
        {
            Console.WriteLine($"Часы: {hour} Минуты: {min} Секунды: {second}");
        }

        public void HowMinets()
        {
            Console.WriteLine($"Всего минут - {hour * 60 + min}");
        }

        public void HowSecond()
        {
            Console.WriteLine($"Всего секунд - {(hour * 60 + min)*60 + second}");
        }
    }
}
