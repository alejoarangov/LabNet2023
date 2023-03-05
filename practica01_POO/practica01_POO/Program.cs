using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica01_POO.Entidades;
using practica01_POO.Servicios;


namespace practica01_POO
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Practica 01_POO");
            Console.WriteLine("--AlejoArangoV--\n");

            var pedirDatos = new PedirDatos();
            var mostrarLista = new MostrarDatos();

            // Ingresar los datos a la lista
            var listaTrans = pedirDatos.IngresarPasajeros();
            
            // Acciones con la lista
            mostrarLista.MostrarAcciones(listaTrans);
           
        }


        
    }
}
