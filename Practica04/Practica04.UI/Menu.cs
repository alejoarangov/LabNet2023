using Microsoft.Win32;
using Practica04.Logic;
using Practica04.UI;
using Practica04.Utils;
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

        #region HeadMenu
        private int HeadMenu()
        {
            Console.Clear();
            Console.WriteLine("\nPractica 04 - Ejercicios con Linq \n" +
                                  "Digite un número (# Ejercicio) entre 1 - 13\n" +
                                  "Digite '0' para Salir..\n");

            string action = Console.ReadLine();
            return (action.IsNum(0, 13)) ? Convert.ToInt32(action) : 14;
        }
        #endregion


        #region ShowMenu
        public void ShowMenu()
        {
            ViewLinq viewLinq = new ViewLinq();
            bool continuar = true;
            do
            {
                int option = HeadMenu();
                switch (option)
                {
                    case 0:
                        continuar = false;
                        Console.WriteLine("Terminado...");
                        Console.ReadKey();
                        break;
                    case 1:
                        viewLinq.ViewExercise1();
                        Console.ReadKey();
                        break;
                    case 2:
                        viewLinq.ViewExercise2();
                        Console.ReadKey();
                        break;
                    case 3:
                        viewLinq.ViewExercise3();
                        Console.ReadKey();
                        break;
                    case 4:
                        viewLinq.ViewExercise4();
                        Console.ReadKey();
                        break;
                    case 5:
                        viewLinq.ViewExercise5();
                        Console.ReadKey();
                        break;
                    case 6:
                        viewLinq.ViewExercise6();
                        Console.ReadKey();
                        break;
                    case 7:
                        viewLinq.ViewExercise7();
                        Console.ReadKey();
                        break;
                    case 8:
                        viewLinq.ViewExercise8();
                        Console.ReadKey();
                        break;
                    case 9:
                        viewLinq.ViewExercise9();
                        Console.ReadKey();
                        break;
                    case 10:
                        viewLinq.ViewExercise10();
                        Console.ReadKey();
                        break;
                    case 11:
                        viewLinq.ViewExercise11();
                        Console.ReadKey();
                        break;
                    case 12:
                        viewLinq.ViewExercise12();
                        Console.ReadKey();
                        break;
                    case 13:
                        viewLinq.ViewExercise13();
                        Console.ReadKey();
                        break;
                    case 14:
                        Console.WriteLine("Digite una opción válida");
                        Console.ReadKey();
                        break;
                }
            }
            while (continuar);
        }
        #endregion

        




    }
}
