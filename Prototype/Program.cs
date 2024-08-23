using Prototype;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle("Red", 10, 20);
        Rectangle rectClone = ((IMyCloneable<Rectangle>)rect).Clone();
        Console.WriteLine($"Original Rectangle: Color={rect.Color}, Width={rect.Width}, Height={rect.Height}");
        Console.WriteLine($"Cloned Rectangle: Color={rectClone.Color}, Width={rectClone.Width}, Height={rectClone.Height}");

        Circle circle = new Circle("Blue", 5);
        Circle circleClone = ((IMyCloneable<Circle>)circle).Clone();
        Console.WriteLine($"Original Circle: Color={circle.Color}, Radius={circle.Radius}");
        Console.WriteLine($"Cloned Circle: Color={circleClone.Color}, Radius={circleClone.Radius}");

        Square square = new Square("Green", 7);
        Square squareClone = ((IMyCloneable<Square>)square).Clone();
        Console.WriteLine($"Original Square: Color={square.Color}, Side={square.Side}");
        Console.WriteLine($"Cloned Square: Color={squareClone.Color}, Side={squareClone.Side}");
    }
}