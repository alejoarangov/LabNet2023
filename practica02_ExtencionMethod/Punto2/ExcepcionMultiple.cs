using practica02_ExtencionMethod.Extensions;
using practica02_ExtencionMethod.Front;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod.Punto2
{
    public class ExcepcionMultiple
    {

        public string DivisionDosNum()
        {
            Validar validar = new Validar();
            string result;
            try
            {
                decimal dividendo = validar.ValidarNumeroTry("Ingresa el Dividendo");
                decimal divisor = validar.ValidarNumeroTry("Ingresa el Divisor");
                
                try 
                {
                    decimal val = dividendo.Division(divisor);
                    result = $"El resultado de dividir {dividendo} entre {divisor} es: {val} ";
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            catch (DivideByZeroException ex)
            {
                result = $"OJITO!! No se puede dividir por cerooo : {ex}";
            }
            catch (Exception ex)
            {
                result = $"Lo que digitaste no es un número : {ex}";
            }
            return result;
        }
       
    }
}
