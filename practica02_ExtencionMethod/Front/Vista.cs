using practica02_ExtencionMethod.Punto1;
using practica02_ExtencionMethod.Punto2;
using practica02_ExtencionMethod.Front;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica02_ExtencionMethod.Punto3;
using practica02_ExtencionMethod.Punto4;
using practica02_ExtencionMethod.Exceptions;

namespace practica02_ExtencionMethod.Front
{
    public class Vista
    {
        #region Encabezado
        public void Encabezado()
        {
            Console.WriteLine("--<AlejoArangoV>--\n"+
                              "---LAB-NET-2023---\n"+
                              "   PRACTICA 02\n");
        }
        #endregion

        #region Despedida
        public void Despedida()
        {
            Console.WriteLine("Eso es todo Amigos... ");
            Console.ReadKey();
        }
        #endregion

        #region Punto1
        public void Punto1()
        {
            ExcepcionSimple excepcionSimple = new ExcepcionSimple();
            Validar validar = new Validar();

            Console.WriteLine("Punto 1 - Excepcion Simple");
            Console.WriteLine("Cualquier valor se dividirá por 0\n");
            string msnInicio = "Ingrese un número entero positivo";
            string msnError = "ATENCION.. Ingrese solo números enteros positivos";
            int numero = validar.ValidarNumeroIf(msnInicio, msnError, 0);

            Console.WriteLine(excepcionSimple.DivisionPorCero(numero));
            Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
        #endregion

        #region Punto2
        public void Punto2()
        {
            ExcepcionMultiple excepcionMultiple = new ExcepcionMultiple();
            Validar validar = new Validar();

            Console.WriteLine("Punto 2 - Excepcion Multiple");
            Console.WriteLine("Para esta división se debe ingresar los dos números\n");
            
            Console.WriteLine(excepcionMultiple.DivisionDosNum());
            Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
        #endregion

        #region Punto3
        public void Punto3()
        {
            Logic logic = new Logic();
            Validar validar = new Validar();

            Console.WriteLine("Punto 3 - Enviar una Excepción desde el back y capturar en el front");
            Console.WriteLine("Se dividirá 0 entre 0\n");
            
            try
            {
                logic.ExcepcionThrow();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"*******Mensaje:\n {ex.Message}");
                Console.WriteLine($"*******Descripción:\n {ex.StackTrace}");
            }
            
            Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
        #endregion

        #region Punto4
        public void Punto4()
        {
            ExcepcionPersonalizada excepcionPersonalizada = new ExcepcionPersonalizada();

            Console.WriteLine("Punto 4 - Lanzar una Excepción personalizada y capturar en el front");
            Console.WriteLine("Se Lanzará 'CustomException'\n");
            
            try
            {
                excepcionPersonalizada.LanzarExcepcionPersonalizada();
            }
            catch(CustomException ex) 
            {
                Console.WriteLine($"*******Mensaje:\n {ex.Message}");
                Console.WriteLine($"*******Descripción:\n {ex.StackTrace}");
            }

            Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
        #endregion

    }
}
