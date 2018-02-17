using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using NETPractice.Classes.Exceptions;

namespace NETPractice.Classes {

    public class Cube {

        private readonly List<Point> _vertices = new List<Point>();
        public readonly double Length;

        public Cube() {
            _vertices.Add(new Point(0, 0, 0));
            _vertices.Add(new Point(1, 0, 0));
            _vertices.Add(new Point(1, 1, 0));
            _vertices.Add(new Point(0, 1, 0));
            _vertices.Add(new Point(0, 0, 1));
            _vertices.Add(new Point(1, 0, 1));
            _vertices.Add(new Point(1, 1, 1));
            _vertices.Add(new Point(0, 1, 1));
            Length = 1;
        }

        public Cube(string path) {
            using (StreamReader streamReader = new StreamReader(path)) {
                string line = streamReader.ReadLine();
                while (line != null) {
                    string[] coords = line
                        .Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Split(' ');
                    
                    if (coords.Length != 3) throw new InvalidDataException();

                    try {
                        _vertices.Add(
                            new Point(
                                double.Parse(coords[0]),
                                double.Parse(coords[1]),
                                double.Parse(coords[2])
                            )
                        ); 
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                        throw new InvalidDataFormatException();
                    }
                    
                    line = streamReader.ReadLine();
                }
                
                if (_vertices.Count != 8) throw new InvalidDataException();
            }

            Length = GetLength();
            if (!IsValid()) throw new InvalidDataException();
        }
        
        // минимальное расстояние от текущей точки до всех остальных считаем длиной ребра куба
        private double GetLength() {
            Point temp = _vertices.First();
            
            return _vertices
                .Where(x => x != temp)
                .Select(vertex => Point.GetDistance(temp, vertex))
                .Min();
        }

        public List<Point> GetVertices() {
            return _vertices;
        }
        
        // если существует 
        // а) ровно три вершины, удалённых от текущей на длину ребра куба
        // б) ровно три вершины, удалённых от текущей на длину диагонали грани куба
        // в) ровно одна вершина, удалённая от текущей на длину диагонали куба
        // то данные 8 точек считаем кубом
        public bool IsValid() {
            double cubeFaceDiagonal = Math.Sqrt(2) * Length;    // диагональ грани куба
            double cubeDiagonal = Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(cubeFaceDiagonal, 2));    // диагональ куба
            bool valid = false;

            int cubeEdgeCounter = 0,
                cubeFaceDiagonalCounter = 0,
                cubeDiagonalCounter = 0;
            
            for (int i = 0; i < _vertices.Count; i++) {
                for (int j = 1; j < _vertices.Count; j++) {
                    if (Math.Abs(Point.GetDistance(_vertices[i], _vertices[j]) - Length) < 0.001) {
                        cubeEdgeCounter++;
                        continue;
                    }

                    if (Math.Abs(Point.GetDistance(_vertices[i], _vertices[j]) - cubeFaceDiagonal) < 0.001) {
                        cubeFaceDiagonalCounter++;
                        continue;
                    }

                    if (Math.Abs(Point.GetDistance(_vertices[i], _vertices[j]) - cubeDiagonal) < 0.001) {
                        cubeDiagonalCounter++;
                    }
                }

                if (cubeEdgeCounter == 3 && cubeFaceDiagonalCounter == 3 && cubeDiagonalCounter == 1) valid = true;
            }

            return valid;
        }
        
        public double GetArea() {
            return Length * Length;
        }

        public double GetCubage() {
            return GetArea() * Length;
        }

        public void Show(StreamWriter streamWriter) {
            streamWriter.WriteLine("vertices:");
            foreach (var vertex in _vertices) {
                streamWriter.WriteLine(vertex);
            }
        }
        
        public void Show() {
            Console.WriteLine("vertices:");
            foreach (var vertex in _vertices) {
                Console.WriteLine(vertex);
            }
        }
        
    }

}