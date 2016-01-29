using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(GetFiles.GetFileExtension("example"));
            Console.WriteLine(GetFiles.GetFileExtension("example.pdf"));
            Console.WriteLine(GetFiles.GetFileExtension("example.new.pdf"));

            Console.WriteLine(GetFiles.GetFileNameWithoutExtension("example"));
            Console.WriteLine(GetFiles.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(GetFiles.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                CalculateDistance.CalcDistance2D(1, -2, 3, 4));

            Console.WriteLine("Distance in the 3D space = {0:f2}",
                CalculateDistance.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Utils.Width = 3;
            Utils.Height = 4;
            Utils.Depth = 5;

            Console.WriteLine("Volume = {0:f2}", Utils.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Utils.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Utils.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Utils.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Utils.CalcDiagonalYZ());
        }
    }
}
