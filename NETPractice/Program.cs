using System;
using NETPractice.Classes;

namespace NETPractice {

    internal class Program {

        public static void Main(string[] args) {
            Cube test = new Cube();
            Cube cube = new Cube("../../cubeExample.txt");
            Console.WriteLine(cube.GetArea());
            Console.WriteLine(cube.GetCubage());
            Console.WriteLine(test.IsValid());
            Console.WriteLine(cube.IsValid());
        }

    }

}