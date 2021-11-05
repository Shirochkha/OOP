using System;

namespace lab2
{
    /// <summary>
    /// Definite integral.
    /// </summary>
    public class DefiniteIntegral
    {

            /// <summary>
            /// Lower and upper limit of a definite integral.
            /// </summary>
            public double a, b;

            /// <summary>
            /// Steps.
            /// </summary>
            public int m;// m количество шагов

            /// <summary>
            /// Definite integral.
            /// </summary>
            /// <param name="ina">Lower limit.</param>
            /// <param name="inb">Upper limit.</param>
            /// <param name="inm">Steps.</param>
            public DefiniteIntegral(double ina, double inb, int inm)
            {
               if (ina < inb) { a = ina; b = inb; }  //меняем а и б местами, для правильных расчетов
               else { b = ina; a = inb; }
               m = inm;
            }


        /// <summary>
        /// Operator overloading  +.
        /// </summary>
        /// <param name="Integral1"></param>
        /// <param name="Integral2"></param>
        /// <returns>Sum integrals.</returns>
        public static double operator +(DefiniteIntegral Integral1, DefiniteIntegral Integral2) //оператор сложения комплексных чисел
        {
            double S1 = CalculationMethod.Rectangle(Integral1);
            double S2 = CalculationMethod.Rectangle(Integral2);
            return (S1 + S2);
        }

        /// <summary>
        /// Operator overloading *.
        /// </summary>
        /// <param name="Integral1"></param>
        /// <param name="number"></param>
        /// <returns>Multiplication of an integral by a number.</returns>
        public static double operator *(DefiniteIntegral Integral1, double number) //оператор сложения комплексных чисел
        {
            double S1 = CalculationMethod.Rectangle(Integral1);
            return (S1 * number);
        }
    }
}
