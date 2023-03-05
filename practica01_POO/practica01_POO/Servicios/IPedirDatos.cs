using practica01_POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica01_POO.Servicios
{
    internal interface IPedirDatos
    {
        List<TransportePublico> IngresarPasajeros();
        int ValidarNumero(string mensajeInicio, string mensajeError, int numDesde, int numHasta);
    }
}
