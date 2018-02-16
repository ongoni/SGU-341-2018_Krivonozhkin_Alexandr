using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NETPractice.Classes {

    public class Cube {

        private readonly List<Point> vertices = new List<Point>();
        public readonly double length;

        public Cube() {
            vertices.Add(new Point(0, 0, 0));
            vertices.Add(new Point(1, 0, 0));
            vertices.Add(new Point(1, 1, 0));
            vertices.Add(new Point(0, 1, 0));
            vertices.Add(new Point(0, 0, 1));
            vertices.Add(new Point(1, 0, 1));
            vertices.Add(new Point(1, 1, 1));
            vertices.Add(new Point(0, 1, 1));
            length = 1;
        }

        public Cube(string path) {
            using (StreamReader streamReader = new StreamReader(path)) {
                string line = streamReader.ReadLine();
                while (line != null) {
                    string[] coords = line.Split(' ');
                    if (coords.Length != 3) throw new InvalidDataException();

                    try {
                        vertices.Add(
                            new Point(
                                Double.Parse(coords[0]), 
                                Double.Parse(coords[1]), 
                                Double.Parse(coords[2])
                            )
                        );
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }
                    
                    line = streamReader.ReadLine();
                }
            }

            length = GetLength();
            if (!isValid()) throw new InvalidDataException();
        }
        
        private double GetLength() {
            Point temp = vertices.First();
            List<double> distances = new List<double>();
            List<Point> filteredVertices = vertices.Where(x => x != temp).ToList();

            foreach (Point vertex in filteredVertices) {
                distances.Add(Point.GetDistance(temp, vertex));
            }

            return distances.Min();
        }
        
        private bool isValid() {
            //quick maths
            // ...
            return true;
        }
        
        public double GetArea() {
            return length * length;
        }

        public double GetCubage() {
            return GetArea() * length;
        }
        
    }

}