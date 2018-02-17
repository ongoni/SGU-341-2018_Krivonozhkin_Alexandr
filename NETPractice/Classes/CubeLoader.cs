using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using NETPractice.Classes.Exceptions;

namespace NETPractice.Classes
{
    static class CubeLoader
    {
        private static readonly string AllowedSeparator 
            = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private const int AllowedCoordsCount = 3;
        private const int AllowedVerticesCount = 8;
        
        public static Cube LoadFromTextFile(string path)
        {   
            List<Point> vertices = new List<Point>();
            
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line = streamReader.ReadLine();
                
                while (line != null && vertices.Count != AllowedVerticesCount)
                {
                    string[] coords = AllowedSeparator != "."
                        ? line.Replace(".", AllowedSeparator).Split(' ')
                        : line.Split(' ');

                    if (coords.Length != AllowedCoordsCount)
                    {
                        throw new InvalidDataException("point must contain only 3 coordinates");
                    }

                    try
                    {
                        vertices.Add(
                            new Point(
                                double.Parse(coords[0]),
                                double.Parse(coords[1]),
                                double.Parse(coords[2])
                            )
                        );
                    }
                    catch (Exception e)
                    {
                        throw new InvalidDataFormatException("couldn't parse vertex coordinates");
                    }

                    line = streamReader.ReadLine();
                }
            }
            
            Cube cube = new Cube(vertices);

            if (!cube.IsValid())
            {
                throw new InvalidDataException();
            }

            return cube;
        }
        
    }

}
