using System;


namespace Operators_Overloading
{
    internal class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector()
        {

        }
        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }

        // Перегрузка бинарных операторов
        // Перегрузка бинарный +
        public  static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector { X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y};
        }

        // Перегрузка бинарный +
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            return new Vector { X = vector1.X - vector2.X, Y = vector1.Y - vector2.Y };
        }

        public static Vector operator *(Vector vector, int value )
        {
            
            return new Vector { X = vector.X * value, Y = vector.Y * value };
        }
        public static Vector operator *( int value, Vector vector)
        {
            return new Vector { X = vector.X * value, Y = vector.Y * value };
        }

        public override string ToString()
        {
            return $"Vector: X = {X}, Y = {Y}";
        }

    }
}
