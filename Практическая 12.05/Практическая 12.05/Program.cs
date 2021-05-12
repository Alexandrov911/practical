using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_12._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число r");
            double r = Convert.ToDouble(Console.ReadLine());
            r = a / 2;
            double v = a * a * a;
            double v1 = (4 / 3) * 3.14 * r * r * r;
            double m = v - v1;
            Console.WriteLine(" Объём куба " + v+ " Объём шара " + v1+ " Процент ушедшего материала в отходы "+m);
            Console.ReadKey();


        }
    }
}
