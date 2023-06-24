using System;
using Abstrato.Entities.Enums;

namespace Abstrato.Entities
{
        class Circle : Shape //Circulo
    {
        public Double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
           return Math.PI * Radius * Radius;
        }
    }
}