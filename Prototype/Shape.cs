/*
Базовый класс для всех фигур.
Содержит свойства, общие для всех фигур, такие как Color.
Реализует интерфейсы IMyCloneable<Shape> и ICloneable.
*/

namespace Prototype
{
    public abstract class Shape : IMyCloneable<Shape>, ICloneable
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        public abstract Shape Clone();

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
