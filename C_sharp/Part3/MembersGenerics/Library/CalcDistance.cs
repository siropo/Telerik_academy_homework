using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class CalcDistance
    {
        static double CalcPoints(Point3D pointOne, Point3D pointTwo)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(pointOne.X - pointTwo.X, 2) + Math.Pow(pointOne.Y - pointTwo.Y, 2) + Math.Pow(pointOne.Z - pointTwo.Z, 2));

            return distance;
        }
    }
}
