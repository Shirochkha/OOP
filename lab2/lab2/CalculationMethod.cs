using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    /// <summary>
    /// Calculation rectangle method.
    /// </summary>
    public class CalculationMethod
    {
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="I">Integral.</param>
        /// <returns>Partial sum of a definite integral.</returns>
        public static double Rectangle(DefiniteIntegral I)//Вычисляет частную сумму по методу левых прямоугольников
        {
            double x, sum = 0, h = (I.b - I.a) / I.m;// деления всего промежутка интегрирования на отрезки одинаковой длины e
            for (int i = 0; i < I.m; i++)
            {
                x = I.a + i * h;
                sum += SubIntegralFun.Sif1(x);
            }
            return (sum * h);
        }
    }
}
