
using Pract_4_OK;
namespace TestShape
{
    public class TestShapes
    {
        [Fact]
        public void CreateRectangleWidth()
        {
            double Width = 3;
            double Height = 3;
            Rectangle rectangle = new Rectangle(Width, Height);
            Assert.Equal(Width, rectangle.Width);
        }

        [Fact]
        public void CreateRectangleHeight()
        {
            double Width = 3;
            double Height = 3;
            Rectangle rectangle = new Rectangle(Width, Height);
            Assert.Equal(Width, rectangle.Width);
        }

        [Fact]
        public void CreateTriangleFirst()
        {
            double first = 3;
            double second = 3;
            double third = 3;
            Triangle triangle = new Triangle(first, second, third);
            Assert.Equal(first, triangle.SideA);
        }

        [Fact]
        public void CreateTriangleSecond()
        {
            double first = 3;
            double second = 3;
            double third = 3;
            Triangle triangle = new Triangle(first, second, third);
            Assert.Equal(second, triangle.SideB);
        }

        [Fact]
        public void CreateTriangleThird()
        {
            double first = 3;
            double second = 3;
            double third = 3;
            Triangle triangle = new Triangle(first, second, third);
            Assert.Equal(third, triangle.SideC);
        }

        [Fact]
        public void AreaCheckRectangle()
        {
            double Width = 3;
            double Height = 3;
            double AreaRec = Width * Height;
            Rectangle rectangle = new Rectangle(Width, Height);
            Assert.Equal(AreaRec, rectangle.Area());
        }

        [Fact]
        public void PerimeterCheckRectangle()
        {
            double Width = 3;
            double Height = 3;
            double PerRec = Width + Height;
            Rectangle rectangle = new Rectangle(Width, Height);
            Assert.Equal(PerRec, rectangle.Perimeter());
        }


        [Fact]
        public void ExceptionCheckRectangleWidth()
        {
            double Width = -3;
            double Height = 3;
            Assert.Throws<InvalidCastException>(() => new Rectangle(Width, Height));
        }

        [Fact]
        public void ExceptionCheckRectangleHeight()
        {
            double Width = 3;
            double Height = -3;
            Assert.Throws<InvalidCastException>(() => new Rectangle(Width, Height));
        }

        [Fact]
        public void ExceptionCheckTriangleSideA()
        {
            double first = -3;
            double second = 3;
            double third = 3;
            Assert.Throws<InvalidCastException>(() => new Triangle(first, second, third));
        }

        [Fact]
        public void ExceptionCheckTriangleSideB()
        {
            double first = 3;
            double second = -3;
            double third = 3;
            Assert.Throws<InvalidCastException>(() => new Triangle(first, second, third));
        }

        [Fact]
        public void ExceptionCheckTriangleSideC()
        {
            double first = 3;
            double second = 3;
            double third = -3;
            Assert.Throws<InvalidCastException>(() => new Triangle(first, second, third));
        }

        [Fact]
        public void AreaCheckTriangle()
        {
            double first = 3;
            double second = 3;
            double third = 3;
            double p = (first + second + third) / 2;
            double areaTriangle = Math.Sqrt(p * (p - first) * (p - second) * (p - third));
            Triangle triangle = new Triangle(first, second, third);
            Assert.Equal(areaTriangle, triangle.Area());
        }

        [Fact]
        public void PerimeterCheckTriangle()
        {
            double first = 3;
            double second = 3;
            double third = 3;
            double perimTriangle = first + second + third;
            Triangle triangle = new Triangle(first, second, third);
            Assert.Equal(perimTriangle, triangle.Perimeter());
        }

        [Fact]
        public void NotRightPerimeterCheckTriangle()
        {
            double first = 3;
            double second = 3;
            double third = 3;
            double perimTriangle = first + second + third - 1;
            Triangle triangle = new Triangle(first, second, third);
            Assert.Equal(perimTriangle, triangle.Perimeter());
        }
    }
}