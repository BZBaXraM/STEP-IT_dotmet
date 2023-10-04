using System;


namespace Operators_Overloading
{

    class CPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    struct SPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Перегрузка унарных операторов
            // Перегрузка унарных операторов
            //Point point = new Point();
            //point.X = 25;
            //point.Y = 32;
            //Console.WriteLine(point);
            //point++;
            //Console.WriteLine(point);
            //point = -point;
            //Console.WriteLine(point);
            //point--;
            //Console.WriteLine(point);

            #endregion

            #region Перегрузка бинарных операторов
            //Point point1 = new Point { X = 2, Y = 3 };
            //Point point2 = new Point { X = 3, Y = 1 };

            //Vector vector1 = new Vector(point1, point2);
            //Vector vector2 = new Vector { X = 2, Y = 3 };
            //Console.WriteLine($"\tВектора:\n{vector1}\n{vector2}");
            //Console.WriteLine($"\n\tСложение векторов:\n {vector1 + vector2}");
            //Console.WriteLine($"\n\tРазность векторов:\n {vector1 - vector2}");
            //Console.WriteLine("\n Введите целое число: ");
            //int number = int.Parse(Console.ReadLine());
            //vector1 *= number;
            //Console.WriteLine(vector1);
            //vector1 = number * vector1;
            //Console.WriteLine(vector1);
            #endregion

            #region ReferenceEquals Equals
            // Reference type ReferenceEquals()
            //Console.WriteLine("Reference type ReferenceEquals()");
            //CPoint cPoint1 = new CPoint {X = 10, Y=10 };
            //CPoint cPoint2 = new CPoint {X = 10, Y=10 };
            //CPoint cPoint3 = cPoint1;

            //Console.WriteLine($"ReferenceEquals(cPoint1, cPoint1) = " +
            //                    $"{ReferenceEquals(cPoint1, cPoint1)}"); // True

            //Console.WriteLine($"ReferenceEquals(cPoint1, cPoint2) = " +
            //                    $"{ReferenceEquals(cPoint1, cPoint2)}");// False

            //Console.WriteLine($"ReferenceEquals(cPoint1, cPoint3) = " +
            //                    $"{ReferenceEquals(cPoint1, cPoint3)}"); // True

            //// Value type ReferenceEquals()
            //Console.WriteLine("\nValue type ReferenceEquals()");
            //SPoint sPoint = new SPoint { X = 10, Y = 10 };
            //Console.WriteLine($"ReferenceEquals(sPoint, sPoint) = " +
            //                    $"{ReferenceEquals(sPoint, sPoint)}"); // False

            //// Reference type Equals()
            //Console.WriteLine("\nReference type Equals()");
            //Console.WriteLine($"Equals(cPoint1, cPoint1) = " +
            //                    $"{Equals(cPoint1, cPoint1)}"); // True
            //Console.WriteLine($"Equals(cPoint1, cPoint2) = " +
            //                    $"{ReferenceEquals(cPoint1, cPoint2)}");// False

            //Console.WriteLine($"Equals(cPoint1, cPoint3) = " +
            //                    $"{ReferenceEquals(cPoint1, cPoint3)}"); // True


            //// Value type Equals()
            //Console.WriteLine("\nValue type Equals()");
            //SPoint sPoint1 = new SPoint { X = 10, Y = 10 };
            //SPoint sPoint2 = sPoint;

            //Console.WriteLine($"Equals(sPoint, sPoint) = " +
            //                    $"{Equals(sPoint, sPoint)}"); // True

            //Console.WriteLine($"Equals(sPoint, sPoint1) = " +
            //                    $"{Equals(sPoint, sPoint1)}");// True

            //Console.WriteLine($"Equals(sPoint, sPoint2) = " +
            //                    $"{Equals(sPoint, sPoint2)}");// True

            #endregion

            #region Опрераторы сравнения

            //Point point = new Point();
            //Point point1 = new Point();
            //Console.WriteLine(Equals(point, point1));
            //Console.WriteLine(point.Equals(point1));
            //Console.WriteLine(point > point1);
            //Console.WriteLine(point != point1);
            #endregion


            Point point = new Point { X = 3, Y = 2 };
            Point point2 = new Point { X = 1, Y = 0 };

            //if (point)
            //{
            //    Console.WriteLine("Точка не в начале координат");
            //}
            //else
            //{
            //    Console.WriteLine("Точка в начале координат");
            //}

            if (point || point2) Console.WriteLine("true");
            else Console.WriteLine("false");


            // Перегрузка операторов преобразования
            // Индексаторы
        }
    }
}