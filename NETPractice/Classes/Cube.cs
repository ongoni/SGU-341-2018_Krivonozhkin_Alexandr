using System;
using System.Collections.Generic;
using System.Linq;

namespace NETPractice.Classes {

    public class Cube
    {
        private const double Exatness = 0.001;
        
        public List<Point> Vertices { get; }
        public double EdgeLength { get; }
        public double Area { get; }
        public double Volume { get; }

        public Cube(List<Point> vertices)
        {
            Vertices = vertices;
            EdgeLength = GetLength();
            Area = GetArea();
            Volume = GetVolume();
        }
        
        // минимальное расстояние от текущей точки до всех остальных считаем длиной ребра куба
        private double GetLength()
        {
            Point temp = Vertices.First();
            
            return Vertices
                .Where(x => x != temp)
                .Select(vertex => temp.GetDistance(vertex))
                .Min();
        }
        
        private double GetArea() => EdgeLength * EdgeLength;

        private double GetVolume() => GetArea() * EdgeLength;
        
        // если существует 
        // а) ровно три вершины, удалённых от текущей на длину ребра куба
        // б) ровно три вершины, удалённых от текущей на длину диагонали грани куба
        // в) ровно одна вершина, удалённая от текущей на длину диагонали куба
        // то данные 8 точек считаем кубом
        public bool IsValid()
        {
            double cubeFaceDiagonal = Math.Sqrt(2) * EdgeLength;    // диагональ грани куба
            double cubeDiagonal = Math.Sqrt(Math.Pow(EdgeLength, 2) + Math.Pow(cubeFaceDiagonal, 2));    // диагональ куба
            bool valid = false;

            int cubeEdgeCounter = 0,
                cubeFaceDiagonalCounter = 0,
                cubeDiagonalCounter = 0;
            
            for (int i = 0; i < Vertices.Count; i++)
            {
                for (int j = 1; j < Vertices.Count; j++)
                {
                    if (Math.Abs(Vertices[i].GetDistance(Vertices[j]) - EdgeLength) < Exatness)
                    {
                        cubeEdgeCounter++;
                        continue;
                    }

                    if (Math.Abs(Vertices[i].GetDistance(Vertices[j]) - cubeFaceDiagonal) < Exatness)
                    {
                        cubeFaceDiagonalCounter++;
                        continue;
                    }

                    if (Math.Abs(Vertices[i].GetDistance(Vertices[j]) - cubeDiagonal) < Exatness)
                    {
                        cubeDiagonalCounter++;
                    }
                }

                if (cubeEdgeCounter == 3 && cubeFaceDiagonalCounter == 3 && cubeDiagonalCounter == 1)
                {
                    valid = true;
                }
            }

            return valid;
        }
        
    }

}