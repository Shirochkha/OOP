using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Structure associated with a point on a plan.
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// Abscissa of the point.
        /// </summary>
        public double x;

        /// <summary>
        /// Ordinate of the point.
        /// </summary>
        public double y;

        /// <summary>
        /// Point coordinates.
        /// </summary>
        /// <param name="x">Abscissa of the point.</param>
        /// <param name="y">Ordinate of the point.</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Method of measuring the distance between points.
        /// </summary>
        /// <param name="pnt">The value pnt.</param>
        /// <returns>Value of distance between points.</returns>
        public double Len(Point pnt)
        {
            return Math.Sqrt(Math.Pow(x - pnt.x, 2) + Math.Pow(y - pnt.y, 2));
        }
    }
}
