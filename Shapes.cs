using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    public class Triangle : AbstractShape
    {
        int sideLength1;
        int sideLength2;
        int sideLength3;

        public Triangle(int sideLength1, int sideLength2, int sideLength3)
        {
            this.sideLength1 = sideLength1;
            this.sideLength2 = sideLength2;
            this.sideLength3 = sideLength3;
        }
        public override double calcPermetr()
        {
            return sideLength1 + sideLength2 + sideLength3;
        }
        public override double calcSquare()
        {
            double p = calcPermetr() / 2;
            return Math.Sqrt(p * (p - sideLength1) * (p - sideLength2) * (p - sideLength3));
        }
    }
    public class Parallelogram : AbstractShape
    {
        int height;
        int width;
        double angle;
        public Parallelogram(int height, int width, double angle)
        {
            this.height = height;
            this.width = width;
            this.angle = angle * Math.PI / 180;
        }
        public override double calcPermetr()
        {
            return height + width;
        }
        public override double calcSquare()
        {
            return width * height * Math.Sin(angle);
        }
    }
    public class Rectangle : Parallelogram
    {
        public Rectangle(int height, int width) : base (height, width, 90) { }

    }
    public class SquareShape : Rectangle
    {
        public SquareShape(int side) : base(side, side) { }
    }
    public class Trapezoid : AbstractShape
    {
        int lowerBase;
        int upperBase;
        int height;

        public Trapezoid(int lowerBase, int upperBase, int height)
        {
            if (lowerBase > upperBase)
            {
                this.lowerBase = upperBase;
                this.upperBase = lowerBase;
            }
            else
            {
                this.lowerBase = lowerBase;
                this.upperBase = upperBase;
            }
            this.height = height;            
        }

        public override double calcPermetr()
        {
            return lowerBase + upperBase + Math.Sqrt(Math.Pow(height, 2) +
                Math.Pow((lowerBase - upperBase) / 2, 2)) * 2;
        }
        public override double calcSquare()
        {
            return (lowerBase + upperBase) * height / 2;
        }

    }
    public class Rhombus : Parallelogram
    {
        public Rhombus(int side, double angle) : base(side, side, angle) { }
    }
    public class Ellipse : AbstractShape
    {
        double semiAxisA;
        double semiAxisB;
        public Ellipse (double semiAxisA,  double semiAxisB)
        {
            this.semiAxisA = semiAxisA;
            this.semiAxisB = semiAxisB;
        }
        public override double calcPermetr()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(semiAxisA, 2) + Math.Pow(semiAxisB, 2)) / 2);
        }
        public override double calcSquare()
        {
            return 2 * Math.PI * semiAxisA * semiAxisB;
        }

    }
    public class Circle : Ellipse
    {
        public Circle(double radius) : base(radius, radius) { }
    }

    public class CompositeFigure : AbstractShape
    {
        private List<AbstractShape> shapes;

        public CompositeFigure()
        {
            shapes = new List<AbstractShape>();
        }

        public void AddShape(AbstractShape shape)
        {
           shapes.Add(shape);
        }

        public override double calcSquare()
        {
            double totalSquare = 0;
            foreach (var shape in shapes)
            {
                totalSquare += shape.calcSquare();
            }
            return totalSquare;
        }

        public override double calcPermetr()
        {
            throw new NotImplementedException();
        }
    }
}
