using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Main class of hierarhy.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Class field with two methods.
        /// </summary>
        public Point[] Points { get; set; }

        /// <summary>
        /// Figure.
        /// </summary>
        /// <param name="points">The points value.</param>
        public Figure(Point[] points)
        {
            this.Points = points;
        }

        /// <summary>
        /// Calculation of the square.
        /// </summary>
        public abstract double SquareCalculation();

        /// <summary>
        /// Calculation of the perimetr.
        /// </summary>
        public abstract double PerimetrCalculation();
    }
}