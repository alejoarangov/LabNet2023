using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod.Front
{
    public class Menu
    {
        Vista vista = new Vista();
        Validar validar = new Validar();
        public void MostrarMenu()
        {
            bool continuar = true;
            do
            {
                string msnInicio = "\nElija una Opción \n" +
                                  "1 - Punto Uno\n" +
                                  "2 - Punto Dos\n" +
                                  "3 - Punto Tres\n" +
                                  "4 - Punto Cuatro\n" +
                                  "5 - Salir\n";

                string msnError = "Opción NO válida";
                int opcion = validar.ValidarNumeroIf(msnInicio, msnError, 1, 5);

                switch (opcion)
                {
                    case 5:
                        continuar = false;
                        break;
                    case 1:
                        vista.Punto1();
                        break;
                    case 2:
                        vista.Punto2();
                        break;
                    case 3:
                        vista.Punto3();
                        break;
                    case 4:
                        vista.Punto4();
                        break;
                }
            }
            while (continuar);
        }
    }
}
