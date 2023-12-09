using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tringle
    {
        double side1;
        double side2;
        double foundation;

        public Tringle (double side1)
        {
            this.side1 = side1;
            this.side2 = side1;
            this.foundation = side1;
        }

        public Tringle(double side1,double side2,double foundation) : this(side1)
        {
            this.side1 = side1;
            this.foundation = foundation;
        }
        
      public void Inf()
        {
            Console.WriteLine($"Длина стороны 1 - {side1} \n" +
                $"Длина стороны 2 - {side2}\n" +
                $"Длина основания - {foundation}");
        }

        public void PTringle()
        {
            Console.WriteLine($"P = {side1 + side2 + foundation}");
        }
    }
}
