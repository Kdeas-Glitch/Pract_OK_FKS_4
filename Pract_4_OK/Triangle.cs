using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_4_OK
{
    public class Triangle : Shape
    {

        public double SideA { get; set; } = 0;
        public double SideB { get; set; } = 0;
        public double SideC { get; set; } = 0;

        public Triangle(double a, double b, double c)
        {
            if (!(a + b < c || b + c < a || c + a < b))
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
            else
            {
                throw new System.InvalidCastException("Неправильные стороны треугольника");
            }
        }
        public override double Area()
        {
            try
            {
                double p = (SideA + SideB + SideC) / 2;
                double area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
                return area;
            }
            catch (System.OverflowException)
            {
                throw new System.OverflowException("Слишком большие данные");
            }
        }

        public override double Perimeter()
        {
            try
            {
                return SideA + SideB + SideC;
            }
            catch (System.OverflowException)
            {
                throw new System.OverflowException("Слишком большие данные");
            }
        }

        public override string ToString()
        {
            return $"Треугольник Сторона 1: {SideA} Сторона 2: {SideB} Сторона 3: {SideC}";
        }
    }
}
