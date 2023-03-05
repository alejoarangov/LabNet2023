using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica01_POO.Entidades
{
    public class Taxi : TransportePublico
    {
        private readonly int _asientos;
        private readonly int _pasajeros;

        #region Constructor
        public Taxi(int asientos, int pasajeros) : base(asientos, pasajeros)
        {
            _asientos= asientos;
            _pasajeros= pasajeros;
        }
        #endregion

        #region Métodos
        public override string Avanzar(int numTrans)
        {
            return $"El Taxi # {numTrans} avanzó";
        }

        public override string Detenerse(int numTrans)
        {
            return $"El Taxi # {numTrans} se detuvo";
        }

        public override string Resumen(int numTaxi)
        {
            return $"El Taxi {numTaxi} tiene {_asientos} asientos y {_pasajeros} pasajeros";
        }
        #endregion
    }
}
