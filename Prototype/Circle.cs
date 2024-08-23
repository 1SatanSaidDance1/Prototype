/*
Наследуется от Shape.
Содержит свойства, специфичные для круга, такие как Radius.
Реализует интерфейсы IMyCloneable<Circle> и ICloneable.
*/

namespace Prototype
{
    public class Circle : Shape, IMyCloneable<Circle>
    {
        public double Radius { get; set; }

        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override Shape Clone()
        {
            return new Circle(Color, Radius);
        }

        Circle IMyCloneable<Circle>.Clone()
        {
            return (Circle)this.Clone();
        }
    }
}
