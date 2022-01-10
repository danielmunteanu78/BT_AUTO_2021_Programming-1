using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    public class Volume
    {

        public static void VolumeExample()
        {
            double cubeSide = 10;
            float sphereRadius = 5;
            double pyramidSideA = 2;
            double pyramidSideB = 3;
            double pyramidSideC = 4;
            double cylinderRadius = 5;
            double cylinderHeight = 6;
            double thorusInnerRadius = 5;
            double thorusOutterRadius = 6;

            Console.WriteLine("Volume of a cube with side {0} is {1}", cubeSide, Volume.ComputeVolume((double)10));
            Console.WriteLine("Volume of a sphere with radius {0} is {1}", sphereRadius , Volume.ComputeVolume((float)5));
            Console.WriteLine("Volume of a pyramid with length	{0}, width {1}, height {2} is {3}", pyramidSideA, pyramidSideB, pyramidSideC,  Volume.ComputeVolume(2, 3, 4));
            Console.WriteLine("Volume of a cylinder with radius {0} and height {1} is {2} ",cylinderRadius, cylinderHeight, Volume.ComputeVolume((double)5, (double)6));
            Console.WriteLine("Volume of a thorus with r {0} and R {1} is {2} ", thorusInnerRadius, thorusOutterRadius, Volume.ComputeVolume(5, 6));
        }

        public static double ComputeVolume(double lenght)
        {
            return Math.Pow(lenght, 3);
        }
        public static double ComputeVolume(float radius)
        {
            return (((double)4 / (double)3) * Math.PI * ComputeVolume(Convert.ToDouble(radius)));
        }

        public static double ComputeVolume(double lenght, double height, double weight)
        {
            return ((lenght * height * weight) / 3);
        }

        public static double ComputeVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public static double ComputeVolume(double r, float R)
        {
            if (r > R)
            {
                Console.WriteLine("Inner radius must be lower that outter radius!!");
                return 0;
            }
            return Math.PI * Math.Pow(r, 2) * (2 * Math.PI * R);
        }
    }
}
