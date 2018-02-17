using System;
using System.IO;
using NETPractice.Classes;

namespace NETPractice {

    internal class Program {

        public static void Main(string[] args) {
            Cube cube = new Cube("../../cubeExample.txt");

            using (StreamWriter streamWriter = new StreamWriter("../../out.txt")) {
                streamWriter.WriteLine($"area - {cube.GetArea()}");
                streamWriter.WriteLine($"cubage - {cube.GetCubage()}");

                cube.Show(streamWriter);
            }
        }

    }

}