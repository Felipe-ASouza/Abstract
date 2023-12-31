﻿using Abstrato.Entities.Enums;

namespace Abstrato.Entities
{
        class Rectangle : Shape //retangulo
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle(double width, double heigth, Color color) : base(color)
        {
            Width = width;
            Heigth = heigth;
        }
        
        public override double Area()
        {
            return Width * Heigth;
        }
    }
}