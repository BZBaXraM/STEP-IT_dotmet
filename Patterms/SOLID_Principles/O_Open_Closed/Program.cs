// Bad example

//object[] shapes = new object[] {new Rectangle() {
//    Height=5, Width=15},
//    new Circle() { Radius=25},
//    new Triangle(){Height = 35}
//};

//Calculate calculate = new Calculate();
//Console.WriteLine(calculate.Areas(shapes));



//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//}

//class Circle
//{
//    public double Radius { get; set; }
//}

//class Triangle
//{
//    // some fields
//    public double Height { get; set; }
//}

//class Calculate
//{
//    public double Areas(object[] shapes)
//    {
//        double areas = 0;
//        foreach(var shape in shapes)
//        {
//            if (shape is Rectangle r)
//                areas += r.Width * r.Height;

//            else if (shape is Circle c)
//                areas += Math.Pow(c.Radius, 2) * Math.PI;
//            else if (shape is Triangle t)
//                areas += t.Height * 28 / 15;
//        }
//        return areas;
//    }
//}

// Good Example

//Rectangle rectangle = new Rectangle() { Height=5, Width = 6};
//Circle circle = new Circle() { Radius = 65 };
//Square square = new Square() { Side = 7};
//Calculate calculate = new Calculate();
//Console.WriteLine(calculate.Areas(new Shape[] { rectangle, circle, square}));

//abstract class Shape
//{
//    public abstract double Area();
//}

//class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public override double Area() => Width * Height;
//}

//class Circle : Shape
//{
//    public double Radius { get; set; }

//    public override double Area() => Math.Pow(Radius, 2) * Math.PI;
//}


//class Square : Shape
//{
//    public double Side { get; set; }
//    public override double Area() => Math.Pow(Side, 2);
//}
//class Calculate
//{
//    public double Areas(Shape[] shapes) => shapes.Sum(x => x.Area());

//    //public double Areas(Shape[] shapes)
//    //{
//    //    double areas = 0;
//    //    foreach (var shape in shapes)
//    //    {
//    //        areas += shape.Area();
//    //    }
//    //    return areas;
//    //}

//}


// Task bad example

//class Developer
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Position { get; set; }
//    public double Salary { get; set; }

//    public Developer(int id, string? name, string? position, double salary)
//    {
//        Id = id;
//        Name = name;
//        Position = position;
//        Salary = salary;
//    }

//    public double CalculateBonus()
//    {
//        if (Position == "Junior") return Salary * 0.1;
//        else if (Position == "Middle") return Salary * 0.2;
//        else return Salary * 0.3;
//    }
//}




// Good example

//abstract class Developer
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Position { get; set; }
//    public double Salary { get; set; }

//    public Developer(int id, string? name, string? position, double salary)
//    {
//        Id = id;
//        Name = name;
//        Position = position;
//        Salary = salary;
//    }

//    public abstract double CalculateBonus();
   
//}

//class Junior : Developer
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Position { get; set; }
//    public double Salary { get; set;}

//    public Junior(int id, string? name, string? position, double salary):
//        base(id, name, position, salary)
//    {
//        Id = id;
//        Name = name;
//        Position = position;
//        Salary = salary;
//    }
//    public override double CalculateBonus() => Salary * 0.1;
//}
