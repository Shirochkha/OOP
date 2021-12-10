using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
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
            if(ina >= -99 && ina <= 99) 
            {
                if(inb >= -99 && inb <= 99)
                {
                    if (ina < inb) { a = ina; b = inb; }  //меняем а и б местами, для правильных расчетов
                    else throw new IntegralsException();
                        //{ b = ina; a = inb; }
                }
                else throw new IntegralsException2();
            }
            else throw new IntegralsException3();

            if (inm >= 1 && inm <= 10)
            {
                m = inm;
            }
            else throw new IntegralsException4();

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
