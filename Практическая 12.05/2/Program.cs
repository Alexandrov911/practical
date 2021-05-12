using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //11
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число m");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число h");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число p");
            double p = Convert.ToDouble(Console.ReadLine());
            double s = ((a+b)/2)*h;
            double l = m / (p * s);
            Console.WriteLine(" Толщина доски " +l);
            Console.ReadKey();





        }
    }
}
