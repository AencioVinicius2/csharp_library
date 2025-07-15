using System;
using Course.Entities.Enums;
namespace Course.Entities
{
    class Rectangle : Shape
    {
        public double witdh { get; set; }
        public double height { get; set; }

        public Rectangle(double witdh, double height, Color color) : base(color)
        {
            this.witdh = witdh;
            this.height = height;
        }

        public override double Area()
        {
            return 0;
        }
    }
}
