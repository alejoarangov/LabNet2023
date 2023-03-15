using Microsoft.Win32;
using Practica03.Logic;
using Practica03.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Practica03.UI
{
    public class Menu
    {
        #region ShowMenu
        public void ShowMenu()
        {
            bool continuar = true;
            do
            {
                Console.WriteLine("\nElija una Tabla \n" +
                                  "1 - Tabla Categories\n" +
                                  "2 - Tabla Shippers\n" +
                                  "3 - Salir\n");
                                  
                string table = Console.ReadLine();

                if (table.IsDigit() && Convert.ToInt32(table) >= 1 && Convert.ToInt32(table) <= 3)
                {
                    switch (table.ToString())
                    {
                        case "1":
                            CrudTableCategories();
                            break;
                        case "2":
                            CrudTableShippers();
                            break;
                        case "3":
                            continuar = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Digite una opción válida");
                }    
            }
            while (continuar);
        }
        #endregion

        #region HeadCrud
        private int HeadCrud (string tableName)
        {
            Console.Clear();
            Console.WriteLine ($"\nElija una Acción con la tabla {tableName}\n" +
                                  "1 - Mostrar Lista\n" +
                                  "2 - Nuevo Registro\n" +
                                  "3 - Modificar un registro\n" +
                                  "4 - Consultar un registro\n" +
                                  "5 - Eliminar un registro\n" +
                                  "6 - Atrás\n");

            string action = Console.ReadLine();
            if (action.IsDigit() && Convert.ToInt32(action) >= 1 && Convert.ToInt32(action) <= 6)
            {
                return Convert.ToInt32(action);
            }
            else
            {
                return 0;
            }
                
        }
        #endregion

        #region CrudTableCategories
        private void CrudTableCategories()
        {
            ViewCategories viewCategories = new ViewCategories(); 
            bool continuar = true;
            do
            {
                int opcion=HeadCrud("Categories");
                
                switch (opcion)
                {
                    case 1:
                        viewCategories.GetAll();
                        Console.ReadKey();
                        break;
                    case 2:
                        viewCategories.Create();
                        Console.ReadKey();
                        break;
                    case 3:
                        viewCategories.Update();
                        Console.ReadKey();
                        break;
                    case 4:
                        viewCategories.GetByName();
                        Console.ReadKey();
                        break;
                    case 5:
                        viewCategories.Delete();
                        Console.ReadKey();
                        break;
                    case 6:
                        continuar = false;
                        break;
                    case 0:
                        Console.WriteLine("Digita una opción válida");
                        Console.ReadKey();
                        break;
                }
            }
            while (continuar);
        }
        #endregion

        #region CrudTableShippers
        private void CrudTableShippers()
        {
            ViewShippers viewShippers = new ViewShippers();
            bool continuar = true;
            do
            {
                int opcion = HeadCrud("Shippers");

                switch (opcion)
                {
                    case 1:
                        viewShippers.GetAll();
                        Console.ReadKey();
                        break;
                    case 2:
                        viewShippers.Create();
                        Console.ReadKey();
                        break;
                    case 3:
                        viewShippers.Update();
                        Console.ReadKey();
                        break;
                    case 4:
                        viewShippers.GetByName();
                        Console.ReadKey();
                        break;
                    case 5:
                        viewShippers.Delete();
                        Console.ReadKey();
                        break;
                    case 6:
                        continuar = false;
                        break;
                    case 0:
                        Console.WriteLine("Digita una opción válida");
                        Console.ReadKey();
                        break;
                }
            }
            while (continuar);
        }
        #endregion




    }
}
