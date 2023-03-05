using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace practica01_POO.Entidades
{
    
    public class Omnibus : TransportePublico
    {
        private readonly int _asientos;
        private readonly int _pasajeros;

        #region Constructor
        public Omnibus(int asientos, int pasajeros) : base(asientos, pasajeros)
        {
            _asientos = asientos;
            _pasajeros = pasajeros;
        }

        public override string Avanzar(int numTrans)
        {
            return $"El Omnibus # {numTrans} avanzó";
        }

        public override string Detenerse(int numTrans)
        {
            return $"El Omnibus # {numTrans} se detuvo";
        }

        public override string Resumen(int numOmnibus)
        {
            return $"El Omnibus {numOmnibus} tiene {_asientos} asientos y {_pasajeros} pasajeros";
        }
        #endregion


    }
}
