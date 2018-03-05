using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using NETPractice.CubeTask.Entities;
using NETPractice.CubeTask.Exceptions;

namespace NETPractice.CubeTask.DAO
{
    static class CubeLoader
    {
        private static readonly string AllowedSeparator;
        private const int AllowedCoordsCount = 3;
        private const int AllowedVerticesCount = 8;

        static CubeLoader()
        {
            AllowedSeparator  = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        }
        
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
            
            return new Cube(vertices);
        }
        
    }

}
