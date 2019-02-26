using System;

namespace TowerDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            // (x^2 + y^2)^(1/2) rounded to the nearest integer
            return (int) Math.Round(Math.Sqrt(Math.Pow((X - x), 2) + Math.Pow((Y - y), 2)));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
