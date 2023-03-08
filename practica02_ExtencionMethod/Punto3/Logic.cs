using practica02_ExtencionMethod.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod.Punto3
{
    public class Logic
    {
        public void ExcepcionThrow()
        {
            try
            {
                int num = 0;
                decimal result = num.Division();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
