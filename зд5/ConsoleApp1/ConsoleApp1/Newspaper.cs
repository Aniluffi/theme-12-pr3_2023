using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Newspaper
    {
        string name;
        int circulation;
        int numberLanes;

        public Newspaper(string name, int circulation, int numberLanes)
        {
            this.name = name;
            this.circulation = circulation;
            this.numberLanes = numberLanes;
        }

        public void Inf()
        {
            Console.WriteLine($"Информация о газете: \n" +
                $"Название - {name} \n" +
                $"Тираж - {circulation}\n" +
                $"Колличество полос - {numberLanes}\n");
        }

        public void ChangeName(string newName)
        {
            this.name = newName;
            Inf();
        }

        public void ChangeNumber(int newNumber)
        {
            this.circulation = newNumber;
            Inf();
        }
    }
}
