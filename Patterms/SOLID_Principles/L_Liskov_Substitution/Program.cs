
Rectangle r = new(width: 15, height: 10);
r.Width = 20;
Console.WriteLine(Calculate.Area(r));

Square s = new(side: 20);
s.Width = 10;
Console.WriteLine(Calculate.Area(s));


#region Bad Example
// Bad example
//class Rectangle
//{
//    public int Width { get; set; }
//    public int Height { get; set; }
//    public Rectangle(int width, int height)
//    {
//        Width = width;
//        Height = height;
//    }
//}

//class Square : Rectangle
//{
//    public Square(int side) : base(side, side){}
//}

//class Calculate
//{
//    public static double Area(Rectangle rectangle)
//        => rectangle.Width * rectangle.Height;
//}
#endregion


#region Good Example

class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

class Square : Rectangle
{
    override public int Width { 
        get=>base.Width;
        set 
        {
            base.Width = value;
            base.Height = value;
        } 
    }
    override public int Height {
        get => base.Height;
        set 
        {
            base.Height = value;
            base.Width = value;
        } 
    }
    public Square(int side) : base(side, side) { }
}

class Calculate
{
    public static double Area(Rectangle rectangle)
        => rectangle.Width * rectangle.Height;
}

#endregion