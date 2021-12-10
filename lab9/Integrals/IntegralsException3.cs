using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrals
{
    public class IntegralsException3 : Exception
    {
        public IntegralsException3() :
            base("Введите верхний предел от -99 до 99!")
        { }
    }
}
