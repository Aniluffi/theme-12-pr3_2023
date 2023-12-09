using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ActionsNumber
    {
       public double num1;
       public double num2;

        /// <summary>
        ///  конструкторы для инициализации объекта 
        /// </summary>
        /// <param name="num1">число 1</param>
        /// <param name="num2">число 2</param>
        public ActionsNumber(double num1,double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public ActionsNumber()
        {

        }

        /// <summary>
        /// функция формирования строки с информацией об объекте
        /// </summary>
        public void Inf ()
        {
            Console.WriteLine($"Первое вещественное число = {num1},второе = {num2} \n");
        }

        /// <summary>
        /// функция обработки значений полей: вычислить корень квадратный из произведения чисел.
        /// </summary>
        public void Sqrt()
        {
            Console.WriteLine($"корень квадратный из произведения чисел - {Math.Sqrt(num1*num2)} \n");
        }
    }
}
