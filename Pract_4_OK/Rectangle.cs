using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_4_OK
{
    public class Rectangle : Shape
    {
        public double Width { get; set; } = 0;
        public double Height { get; set; } = 0;

        public Rectangle(double width, double height)
        {
            if (width > 0 && height > 0)
            {
                Width = width;
                Height = height;
            }
            else
            {
                throw new System.InvalidCastException("Неправильные стороны прямоугольника");
            }
        }

        public override double Area()
        {
            try
            {
                return Width * Height;
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
                return Width + Height;
            }
            catch (System.OverflowException)
            {
                throw new System.OverflowException("Слишком большие данные");
            }
        }

        public override string ToString()//строка: "Прямоугольник: $Width $Height"
        {
            return $"Прямоугольник ширина {Width} высота {Height}";
        }
    }
}
