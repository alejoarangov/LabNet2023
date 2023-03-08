using practica02_ExtencionMethod.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod.Punto1
{
    public class ExcepcionSimple
    {
        #region DivisionPorCero
        public string DivisionPorCero(int num)
        {
            string result;
            try
            {
                decimal val= num.Division();
                result = "Si se pudo dividir por cero";
            }
            catch (Exception ex) 
            {
                result = $"¡¡HMMM OJITO..No se puede DIVIDIR POR CERO!! : {ex}";
            }
                return result;
        }
        #endregion

    }
}
