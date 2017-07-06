using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double r;
            string inside = "Точка внутри контура!";
            string outside = "Точка вне контура!";
            Console.WriteLine("Введите абсциссу точки: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ординату точки: ");
            y = Convert.ToDouble(Console.ReadLine());
            r = Math.Pow(x, 2) + Math.Pow(y, 2);
            
            if (x >= 0)
            {
                if (y >= -1 && y <= 0)
                    if (r == 1)
                        Console.WriteLine(inside);
                    else Console.WriteLine(outside);
            }
            else if (x <= 0)
            {
                if (x >= -0.5 && x <= 0)
                    if (y >= 0 && y <= 0.5) Console.WriteLine(outside);

            }
            if (x >= -1 && x <= -0.5)
            {
                if (y >= 0 && y <= 1) Console.WriteLine(inside);
            }
            if (y >= 1 && x <= 0.5)
            {
                if (x >= 0 && x <= 1) Console.WriteLine(inside);
            }
            Console.ReadKey();
        }
    }
}
