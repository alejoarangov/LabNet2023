using practica02_ExtencionMethod.Front;
using practica02_ExtencionMethod.Punto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vista vista = new Vista();
            Menu menu = new Menu();

            vista.Encabezado();
            menu.MostrarMenu();
            vista.Despedida();
        }
    }
}
