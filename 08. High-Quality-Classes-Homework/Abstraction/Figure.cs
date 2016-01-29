using System;
namespace Abstraction
{
    internal abstract class Figure : IFigure
    {
        private double width;
        private double height;
        private double radius;

        public Figure()
        {
        }

        public Figure(double radius)
        {
            this.Radius = radius;
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The width of the rectangle cannot be negative!");
                }
                this.width = value;
            }
        }

        public virtual double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height of the rectangle cannot be negative!");
                }
                this.height = value;
            }
        }

        public virtual double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The radius of the circle cannot be negative!");
                }
                this.radius = value;
            }
        }
        
        public abstract double CalcPerimeter();
        
        public abstract double CalcSurface();
    }
}
