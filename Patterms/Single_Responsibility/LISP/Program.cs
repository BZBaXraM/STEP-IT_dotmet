Rectangle rectangle = new(10, 5);
// rectangle.Heigth = 7;

Square square = new(10);

Console.WriteLine(rectangle.Area());
Console.WriteLine(square.Area());

class Rectangle
{
    public int Width { get; set; }
    public int Heigth { get; set; }

    public Rectangle(int width, int heigth)
    {
        Width = width;
        Heigth = heigth;
    }

    public double Area()
        => Width * Heigth;
}

class Square : Rectangle
{
    public Square(int side) : base(side, side)
    {
    }
}

// class Calculate
// {
//     public static double Area(Rectangle rectangle)
//         => rectangle.Width * rectangle.Heigth;
// }