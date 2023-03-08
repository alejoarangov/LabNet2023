using practica02_ExtencionMethod.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod.Punto4
{
    public class ExcepcionPersonalizada
    {
        public void LanzarExcepcionPersonalizada()
        {
            throw new CustomException();
        }
    }
}
