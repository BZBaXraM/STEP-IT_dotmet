using System;

namespace Operators_Overloading
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Перегрузка унарных операторов
        // Перегрузка инкремента ++
        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        // Перегрузка декремента ++
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }

        // Перегрузка унарный - 
        public static Point operator -(Point p)
        {
            return new Point { X = -p.X, Y = -p.Y };
        }

        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }


        // Опрераторы сравнения
        // Переопределение Equals
        public override bool Equals(object? obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2)) >
                Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));
        }

        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2)) <
                Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));
        }


        // Перегрузка true
        public static bool operator true(Point p)
        {
            return (p.X != 0 || p.Y != 0)? true : false;
        }
        public static bool operator false(Point p)
        {
            return (p.X == 0 && p.Y == 0) ? true : false;
        }

        public static Point operator |(Point p1, Point p2)
        {
            if ((p1.X != 0 || p1.Y != 0) || (p2.X != 0 || p2.Y != 0))
                return p2;
            return new Point();
        }

        public static Point operator &(Point p1, Point p2)
        {
            if ((p1.X != 0 || p1.Y != 0) && (p2.X != 0 || p2.Y != 0))
                return p2;
            return new Point();
        }
    }
}
