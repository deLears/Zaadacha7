using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Podzadacha1
    {
        static void Main(string[] args)
        //Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше
        //(создать метод для вычисления  площади  треугольника по длинам его сторон).
        //Для решения задачи можно использовать формулу Герона 
        {
            Console.WriteLine("Введите длины первого треугольника, разделяя их нажатием клавиши Enter");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double a3 = Convert.ToDouble(Console.ReadLine());
            double S1 = SquareTri(a1, a2, a3);
            
            Console.WriteLine("Введите длины второго треугольника, разделяя их нажатием клавиши Enter");
            double b1 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double b3 = Convert.ToDouble(Console.ReadLine());
            double S2 = SquareTri(b1, b2, b3);

            if (S1 == S2)
            {
                Console.WriteLine("Площади равны");
            }
            else
            {
                if (S1 > S2)
                {
                    Console.WriteLine("Площадь первого треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }
            }
            Console.ReadKey();
            }
        static double SquareTri(double A, double B, double C)
        {
            double P = 0.5 * (A + B + C);
            double S = Math.Sqrt(P * ((P - A) * (P - B) * (P - C)));
            return S;
        }
    }

        
    }

