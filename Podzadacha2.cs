using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Podzadacha2
    {
        static void Main(string[] args)
        {
            // Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
            Console.WriteLine("Введите сторону куба:");
            double a = Convert.ToDouble(Console.ReadLine());
            double S, V;
            Cube(a, out S, out V);
            Console.WriteLine("Площадь поверхности куба:{0}",S);
            Console.WriteLine("Объем куба:{0}", V);
            Console.ReadKey();
        }
        static void Cube(double a, out double S, out double V)
        {
            S = 6 * (a*a);
            V = Math.Pow(a,3);
            
        }
    }
}
