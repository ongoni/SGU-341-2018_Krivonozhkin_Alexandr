using System;
using System.IO;
using NETPractice.Classes;

namespace NETPractice {

    internal class Program {

        public static void Main(string[] args)
        {
            Cube cube = CubeLoader.LoadFromTextFile("../../cubeExample.txt");

            using (StreamWriter streamWriter = new StreamWriter("../../out.txt")) {
                streamWriter.WriteLine($"area - {cube.Area}");
                streamWriter.WriteLine($"cubage - {cube.Volume}");
            }
        }

    }

}