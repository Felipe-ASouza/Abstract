using Abstrato.Entities.Enums;

namespace Abstrato.Entities
{
    abstract class Shape //figura
    {
        public Color Color { get; set; }
        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}