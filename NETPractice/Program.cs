using System.IO;
using NETPractice.Encapsulation.DAO;
using NETPractice.Encapsulation.Entities;

namespace NETPractice {

    internal class Program {

        public static void Main(string[] args)
        {
            Cube cube = CubeLoader.LoadFromTextFile("../../cubeExample.txt");

            using (StreamWriter streamWriter = new StreamWriter("../../out.txt")) {
                streamWriter.WriteLine($"area - {cube.Area}");
                streamWriter.WriteLine($"volume - {cube.Volume}");
            }
        }

    }

}
