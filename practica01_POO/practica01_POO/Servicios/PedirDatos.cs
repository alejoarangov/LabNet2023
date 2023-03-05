using practica01_POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace practica01_POO.Servicios
{
    public class PedirDatos :IPedirDatos
    {
        #region IngresarPasajeros
        public List<TransportePublico> IngresarPasajeros()
        {
            Console.WriteLine("Los Omnibuses están configurados con 100 asientos");
            Console.WriteLine("Los Taxis están configurados con 4 asientos\n");

            var listaTran = new List<TransportePublico>();

            int i=0;
            int asientos = 0;

            // Ingresar datos de Omnibus
            asientos = 100;
            for (i = 0; i < 5; i++)
            {
                int pasajeros = ValidarNumero(MensajeInicio("Omnibus",asientos,i+1), MensajeError(asientos),0,asientos);
                listaTran.Add(new Omnibus(asientos, pasajeros));
            }

            // Ingresar datos de Taxi
            asientos = 4;
            for (i = 0; i < 5; i++)
            {
                int pasajeros = ValidarNumero(MensajeInicio("Taxi", asientos, i+1), MensajeError(asientos), 0, asientos);
                listaTran.Add(new Taxi(asientos, pasajeros));
            }
            return listaTran;
        }
        #endregion

        #region MensajeInicio
        private string MensajeInicio(string nombre, int asientos, int numTrans)
        {
            string mensajeInicio = $"\n{nombre} N° {numTrans}\n" +
                                   $"Ingrese # pasajeros Entre 0 y {asientos}";
            return mensajeInicio;
        }
        #endregion

        #region MensajeError
        private string MensajeError(int asientos)
        {
            string mensajeError = $"ATENCION!! ingrese # entre 0 y {asientos}";
            return mensajeError;
        }
        #endregion

        #region ValidarNumero
        public int ValidarNumero(string mensajeInicio,string mensajeError,int numDesde, int numHasta)
        {
            bool continuar = false;
            int numero;
            do
            {
                Console.WriteLine(mensajeInicio);
                var valIngresado = Console.ReadLine();

                if (int.TryParse(valIngresado, out numero))
                {
                    if (numero>= numDesde && numero <= numHasta)
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

    }
}
