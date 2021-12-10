using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
{
    public class IntegralsException4 : Exception
    {
        public IntegralsException4() :
            base("Введите шаг предела от 1 до 10!")
        { }
    }
}
