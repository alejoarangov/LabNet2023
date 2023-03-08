using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod.Front
{
    public class Validar
    {
        #region ValidarNumeroConIf_ConLimite
        public int ValidarNumeroIf(string mensajeInicio, string mensajeError, int numDesde,int numHasta)
        {
            bool continuar = false;
            int numero;
            do
            {
                Console.WriteLine(mensajeInicio);
                var valIngresado = Console.ReadLine();

                if (int.TryParse(valIngresado, out numero))
                {
                    if (numero >= numDesde && numero<=numHasta)
                    {
                        continuar = false;
                    }
                    else
                    {
                        Console.WriteLine(mensajeError);
                        continuar = true;
                    }
                }
                else
                {
                    Console.WriteLine(mensajeError);
                    continuar = true;
                }
            }
            while (continuar);

            return numero;
        }
        #endregion

        #region ValidarNumeroConIf_SinLimite
        public int ValidarNumeroIf(string mensajeInicio, string mensajeError, int numDesde)
        {
            bool continuar = false;
            int numero;
            do
            {
                Console.WriteLine(mensajeInicio);
                var valIngresado = Console.ReadLine();

                if (int.TryParse(valIngresado, out numero))
                {
                    if (numero >= numDesde)
                    {
                        continuar = false;
                    }
                    else
                    {
                        Console.WriteLine(mensajeError);
                        continuar = true;
                    }
                }
                else
                {
                    Console.WriteLine(mensajeError);
                    continuar = true;
                }
            }
            while (continuar);

            return numero;
        }
        #endregion

        #region ValidarNumeroConTRY
        public decimal ValidarNumeroTry(string msnInicio)
        {
            decimal result;
            Console.WriteLine(msnInicio);
            var valIngresado = Console.ReadLine();
            try
            {
                decimal numero = Convert.ToDecimal(valIngresado);
                result = numero;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            return result;
        }
        #endregion
    }
}
