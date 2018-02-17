using System;

namespace NETPractice.Classes {

    public class Point {

        public Point(double x, double y, double z) {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public static double GetDistance(Point a, Point b) {
            return Math.Sqrt(
                Math.Pow(b.X - a.X, 2) +
                Math.Pow(b.Y - a.Y, 2) +
                Math.Pow(b.Z - a.Z, 2)
            );
        }

        public override string ToString() {
            return $"({X}, {Y}, {Z})";
        }

    }

}