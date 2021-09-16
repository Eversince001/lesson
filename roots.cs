using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class roots
    {

        public List<double> root(double a, double b, double c)
        {
            List<double> rt = new List<double>();

            double D;

            D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
            {
                Console.WriteLine("No roots");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                rt.Add(x1); rt.Add(x2);
            }
            return rt;
        }
    }
}
