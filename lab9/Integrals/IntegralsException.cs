using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
{
    public class IntegralsException : Exception
    {
        public IntegralsException() :
            base("Нижний предел больше или равен верхнему!")
        { }

    }
}
