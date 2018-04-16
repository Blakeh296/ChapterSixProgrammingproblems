using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Falling_Distance
{
    class FallingDistance
    {
        public static double CalFallingDistance(double t)
        {
            double distance;
            double g = 9.8;

            double half = .50;
            double gt = ((g * t) * 2);

             distance = Math.Pow(gt, half);

            return distance;
        }
    }
}
