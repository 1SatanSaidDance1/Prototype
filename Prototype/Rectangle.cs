/*
Наследуется от Shape.
Содержит свойства, специфичные для прямоугольника, такие как Width и Height.
Реализует интерфейсы IMyCloneable<Rectangle> и ICloneable.
*/

namespace Prototype
{
    public class Rectangle : Shape, IMyCloneable<Rectangle>
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override Shape Clone()
        {
            return new Rectangle(Color, Width, Height);
        }

        Rectangle IMyCloneable<Rectangle>.Clone()
        {
            return (Rectangle)this.Clone();
        }
    }
}
