using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Class Parallelogram.
    /// </summary>
    public class Parallelogram : Figure
    {
        /// <summary>
        /// Parallelogram.
        /// </summary>
        /// <param name="points"></param>
        public Parallelogram(Point[] points) : base(points)
        {
        }

        /// <summary>
        /// Parallelogram
        /// </summary>
        /// <param name="x1">Abscissa of the point x1.</param>
        /// <param name="y1">Ordinate of the point y1.</param>
        /// <param name="x2">Abscissa of the point x2.</param>
        /// <param name="y2">Ordinate of the point y2.</param>
        /// <param name="x3">Abscissa of the point x3.</param>
        /// <param name="y3">Ordinate of the point y3.</param>
        /// <param name="x4">Abscissa of the point x4.</param>
        /// <param name="y4">Ordinate of the point y4.</param>
        public Parallelogram(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(null) //создает новый конструктор, перегрузка
        {
            Point[] points = new Point[4];
            points[0].x = x1;
            points[0].y = y1;
            points[1].x = x2;
            points[1].y = y2;
            points[2].x = x3;
            points[2].y = y3;
            points[3].x = x4;
            points[3].y = y4;

            this.Points = points;
        }

        /// <summary>
        /// Side A calculation method.
        /// </summary>
        /// <returns>Value of side A</returns>
        public double SideACalculation()
        {
            return Points[0].Len(Points[1]);
        }

        /// <summary>
        /// Side B calculation method.
        /// </summary>
        /// <returns>Value of side B.</returns>
        public double SideBCalculation()
        {
            return Points[1].Len(Points[2]);
        }

        /// <summary>
        /// Side C calculation method.
        /// </summary>
        /// <returns>Value of side C.</returns>
        public double SideCCalculation()
        {
            return Points[2].Len(Points[3]);
        }

        /// <summary>
        /// Side D calculation method
        /// </summary>
        /// <returns>Value of side D.</returns>
        public double SideDCalculation()
        {
            return Points[3].Len(Points[0]);
        }

        /// <summary>
        /// Perimetr calculation method.
        /// </summary>
        /// <returns>Value of perimetr.</returns>
        public override double PerimetrCalculation()
        {
            return 2 * (SideACalculation() + SideBCalculation());
        }

        /// <summary>
        /// Square calculation method.
        /// </summary>
        /// <returns>Value of square.</returns>
        public override double SquareCalculation()
        {
            return Math.Abs(Points[3].y - Points[0].y) * SideACalculation();
        }

        /// <summary>
        /// Method of checking for existance.
        /// </summary>
        /// <returns>Value of flag.</returns>
        public bool IsExist()
        {
            bool flag = false;
            if (SideACalculation() == SideCCalculation() && SideBCalculation() == SideDCalculation())
            {
                flag = true;
                Console.WriteLine("Параллелограмм существует");
            }
            else
                Console.WriteLine("Параллелограмм не существует");
            return flag;
        }

        /// <summary>
        /// Point ownership chek method(vector).
        /// </summary>
        /// <param name="x_point">Abscissa of the point x_point.</param>
        /// <param name="y_point">Ordinate of the point y_point.</param>
        /// <returns>Value of bool IsPointBelong.</returns>
        public bool IsPointBelong(double x_point, double y_point)
        {
            double k = (Points[0].x - x_point) * (Points[1].y - y_point) - (Points[1].x - x_point) * (Points[0].y - y_point);
            double m = (Points[1].x - x_point) * (Points[2].y - y_point) - (Points[2].x - x_point) * (Points[1].y - y_point);
            double n = (Points[2].x - x_point) * (Points[3].y - y_point) - (Points[3].x - x_point) * (Points[2].y - y_point);
            double l = (Points[3].x - x_point) * (Points[0].y - y_point) - (Points[0].x - x_point) * (Points[3].y - y_point);

            if ((k >= 0 && m >= 0 && n >= 0 && l >= 0) || (k<=0 && m<= 0 && n <= 0 && l <= 0))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Input of parallelogram vertices by coordinates [x;y].
        /// </summary>
        /// <returns>Value of Parallelogram A.</returns>
        public static Parallelogram Create()
        {

            Console.WriteLine("\tВведите координаты [P1.x P1.y]: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\tВведите координаты [P2.x;P2.y]: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\tВведите координаты [P3.x;P3.y]: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\tВведите координаты [P4.x;P4.y]: ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());

            Parallelogram A = new Parallelogram(x1, y1, x2, y2, x3, y3, x4, y4);
            return A;
        }

        /// <summary>
        ///  Cheking if a point belongs to a figure.
        /// </summary>
        /// <param name="A">Parallelogram A.</param>
        public static void CheckPointAffiliation(Parallelogram A)
        {
            Console.WriteLine("\tВведите координаты точки (x, y):");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (A.IsPointBelong(x, y))
            {
                Console.WriteLine("\tТочка принадлежит параллелограмму!");
            }
            else
            {
                Console.WriteLine("\tТочка не принадлежит параллелограмму!");
            }
        }
    }
}
