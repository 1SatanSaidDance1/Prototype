/*
Наследуется от Rectangle.
Содержит свойства, специфичные для квадрата, такие как Side.
Реализует интерфейсы IMyCloneable<Square> и ICloneable.
*/

namespace Prototype
{
    public class Square : Rectangle, IMyCloneable<Square>
    {
        public double Side
        {
            get { return Width; }
            set { Width = value; Height = value; }
        }

        public Square(string color, double side) : base(color, side, side)
        {
        }

        public override Shape Clone()
        {
            return new Square(Color, Side);
        }

        Square IMyCloneable<Square>.Clone()
        {
            return (Square)this.Clone();
        }
    }
}
