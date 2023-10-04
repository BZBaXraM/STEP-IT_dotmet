Regtangle regtangle = new Regtangle() {Height = 10, Width = 12};
Circle circle = new Circle() {Radius = 10};

Console.WriteLine(Calculate.Area(new List<Shape> {regtangle, circle, new Triangle() {SomeParameter = 15}}));

#region Bad

// class Regtangle
// {
//     public double Width { get; set; }
//     public double Height { get; set; }
// }
//
// class Circle
// {
//     public double Radius { get; set; }
// }
//
// static class Calculate
// {
//     public static double Area(List<object> shapes)
//     {
//         double area = 0;
//         foreach (var shape in shapes)
//         {
//             if (shape.GetType() == typeof(Circle)) area += Math.Pow(((Circle) shape).Radius, 2) * Math.PI;
//             else if (shape is Regtangle regtangle) area += regtangle.Height * regtangle.Width;
//             else area += 0;
//         }
//
//         return area;
//     }
// }

#endregion

#region Good

abstract class Shape
{
    public abstract double Area();
}

class Regtangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
        => Height * Width;
}

class Triangle : Shape
{
    public int SomeParameter { get; set; }

    public override double Area()
        => SomeParameter *= 10;
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
        => Math.Pow(Radius, 2) * Math.PI;
}

static class Calculate
{
    public static double Area(List<Shape> shapes)
        => shapes.Sum(x => x.Area());
}

#endregion