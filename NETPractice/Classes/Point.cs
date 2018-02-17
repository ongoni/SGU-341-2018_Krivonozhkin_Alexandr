using System;

namespace NETPractice.Classes {

    public class Point {

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double GetDistance(Point other) 
            => Math.Sqrt(
                Math.Pow(other.X - this.X, 2) +
                Math.Pow(other.Y - this.Y, 2) +
                Math.Pow(other.Z - this.Z, 2)
            );

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

    }

}