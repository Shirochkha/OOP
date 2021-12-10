using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
{
    public class IntegralsException2 : Exception
    {
        public IntegralsException2() :
            base("Введите нижний предел от -99 до 99!")
        { }
    }
}
