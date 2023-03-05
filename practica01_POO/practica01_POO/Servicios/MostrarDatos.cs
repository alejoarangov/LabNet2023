using practica01_POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica01_POO.Servicios
{
    public class MostrarDatos
    {
        PedirDatos pedirDatos = new PedirDatos();

        #region MostrarAcciones
        public void MostrarAcciones(List<TransportePublico> listaTransp)
        {
            int opcion=SelecOpcion();

            if (opcion == 1) ImprimirLista(listaTransp);
            else if (opcion == 2)ImprimirMetodo(listaTransp);
        }
        #endregion

        #region SelecOpcion
        private int SelecOpcion()
        {
            string mensajeInicio = "Digite un número según la opción\n" +
                                    "1- Imprimir lista TransportePublico\n" +
                                    "2- Ejecutar un método de un objeto ";

            string mensajeError = "ATENCION!! digite una opción válida";

            int opcion = pedirDatos.ValidarNumero(mensajeInicio, mensajeError, 1, 2);

            return opcion;
        }
        #endregion

        #region ImprimirMetodo
        private void ImprimirMetodo(List<TransportePublico> listaTrans)
        {
            int transporte = SelecTransporte();
            int numT = SelecNumTransporte();
            int metodo = SelecMetodo();

            if (transporte == 1)
            {
                if (metodo == 1)
                    Console.WriteLine($"{ listaTrans[numT - 1].Avanzar(numT)} con {listaTrans[numT - 1].Pasajeros} pasajeros");

                else if (metodo == 2)
                    Console.WriteLine($"{listaTrans[numT - 1].Detenerse(numT)} con {listaTrans[numT - 1].Pasajeros} pasajeros");
            }
            else if (transporte == 2)
            {
                if (metodo == 1)
                    Console.WriteLine($"{listaTrans[numT +4].Avanzar(numT)} con {listaTrans[numT +4].Pasajeros} pasajeros");

                else if (metodo == 2)
                    Console.WriteLine($"{listaTrans[numT +4].Detenerse(numT)} con {listaTrans[numT +4].Pasajeros} pasajeros");
            }
            Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
        #endregion

        #region ImprimirLista
        private void ImprimirLista(List<TransportePublico> ListaTrans)
        {
            int contador=1;
            foreach (var Trans in ListaTrans)
            {
                contador = (contador < 6) ? contador++:contador = 1;
                Console.WriteLine(Trans.Resumen(contador++));
            }

            Console.WriteLine("Terminado...");
            Console.ReadKey();
        }
        #endregion

        #region SelecTransporte
        private int SelecTransporte()
        {
            string mensajeInicio = $"Digite un # segun la opción\n" +
                                  $"1- Omnibus\n" +
                                  $"2- Taxi";
            string mensajeError = "ATENCION!! Seleccione una opcion válida";

            int transporte = pedirDatos.ValidarNumero(mensajeInicio, mensajeError, 1, 2);
            return transporte;
        }
        #endregion

        #region SelecNumTransporte
        private int SelecNumTransporte()
        {
            string mensajeInicio = $"Digite el # del transporte 1-5";
            string mensajeError = "ATENCION!! Digiete un # válido";

            int numTransporte = pedirDatos.ValidarNumero(mensajeInicio, mensajeError, 1, 5);
            return numTransporte;
        }
        #endregion

        #region SelecMetodo
        private int SelecMetodo()
        {
            string mensajeInicio = $"Digite un # segun la opción\n" +
                                  $"1- Avanzar\n" +
                                  $"2- Detenerse";
            string mensajeError = "ATENCION!! Seleccione una opcion válida";

            int metodo = pedirDatos.ValidarNumero(mensajeInicio, mensajeError, 1, 2);
            return metodo;
        }
        #endregion

    }
}
