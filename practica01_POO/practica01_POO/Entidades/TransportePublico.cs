using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica01_POO.Entidades
{
    public abstract class TransportePublico
    {
        #region Constructor
        public TransportePublico(int asientos, int pasajeros)
        {
            this.Asientos = asientos;
            this.Pasajeros = pasajeros;
        }
        #endregion

        #region Propiedaes
        public int Asientos { get; set; }
        public int Pasajeros { get; set; }
        #endregion

        #region Método
        public abstract string Avanzar(int numTrans);
        public abstract string Detenerse(int numTrans);
        public abstract string Resumen(int numTrans);
        #endregion

    }
}
