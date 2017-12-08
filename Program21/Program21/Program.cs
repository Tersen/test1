using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,delta,x1,x2;
            Console.WriteLine("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = b*b - 4*a*c;
            Console.WriteLine("Delta ={0}", delta);
            if (delta >= 0)
            {
                x1 = -b - Math.Sqrt(delta) / 2 * a;
                Console.WriteLine("Miejsce zerowe 1 ={0}",x1);
                x2 = -b + Math.Sqrt(delta) / 2 * a;
                Console.WriteLine("Miejsce zerowe 2 ={0}",x2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Brak pierwiastków");
                Console.ReadLine();
            }
            
        }
    }
}
