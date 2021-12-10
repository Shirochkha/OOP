﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
{
    public class SubIntegralFun
    {
        /// <summary>
        /// Integrand 1.
        /// </summary>
        /// <param name="x">Variable x.</param>
        /// <returns>Integrand 1.</returns>
        public static double Sif1(double x)//подинтегральная функция 1
        {
            return (double)(1 / (x * x * (x + 1.3)));//задается функция
        }
    }
}
