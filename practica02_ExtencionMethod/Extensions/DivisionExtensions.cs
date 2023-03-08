using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod.Extensions
{
    public static class DivisionExtensions
    {
        #region DivisionPorCero
        public static decimal Division(this int numero)
        {
            return numero / 0;
        }
        #endregion

        #region DivisionDosNumeros
        public static decimal Division(this decimal numero, decimal numDivisor)
        {
            decimal result = numero / numDivisor;
            return result;
        }
        #endregion

    }
}
