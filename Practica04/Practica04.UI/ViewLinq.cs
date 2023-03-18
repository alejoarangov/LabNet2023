using Practica04.Entities;
using Practica04.Logic;
using Practica04.Utils;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica04.UI
{
    public class ViewLinq
    {
        LinqLogic linqLogic = new LinqLogic();

        #region Head
        private void Head(int exercNum, string description)
        {
            Console.WriteLine($"Ejercicio {exercNum}");
            Console.WriteLine($"{description}\n");
        }
        #endregion

        #region Exercise 1
        public void ViewExercise1()
        {
            Head(1, "Deveolver un objeto Customer\n");

            Console.WriteLine("Ingrese un Id de Customer (string)");
            string id = Console.ReadLine();

            if (id.IsText())
            {
                try
                {
                    Customers customers = linqLogic.LogicExercise1(id);
                    if (customers != null)
                    {
                        Console.WriteLine($"Id: {customers.CustomerID}\n" +
                                          $"Empresa: {customers.CompanyName}\n" +
                                          $"Contacto: {customers.ContactName}\n" +
                                          $"Ciudad: {customers.City}\n");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el id buscado");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Digite solo texto");
            }
        }
        #endregion

        #region Exercise 2
        public void ViewExercise2 ()
        {
            Head(2, "Devolver todos los productos sin stock");
            try
            {
                List<Products> products= linqLogic.LogicExercise2();
                if (products != null)
                {
                    products.ForEach(p => Console.WriteLine($"Id: {p.ProductID} Nombre: {p.ProductName}"));     
                }
                else
                {
                    Console.WriteLine("No se encontraron productos sin stock");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion

        #region Exercise 3
        public void ViewExercise3()
        {
            Head(3, "devolver productos con stock y que cuestan más de 3 por unidad");
            try
            {
                List<Products> products = linqLogic.LogicExercise3();
                if (products != null)
                {
                    products.ForEach(p => Console.WriteLine($"Id: {p.ProductID} Nombre: {p.ProductName} Precio: {p.UnitPrice}"));
                }
                else
                {
                    Console.WriteLine("No se encontraron productos con stock y precio mayor a 3");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion

        #region Exercise 4
        public void ViewExercise4()
        {
            Head(4, "devolver todos los customers de la Región WA");
            try
            {
                List<Customers> customers = linqLogic.LogicExercise4();
                if (customers != null)
                {
                    customers.ForEach(c => Console.WriteLine($"Id: {c.CustomerID} Empresa: {c.CompanyName} Contacto: {c.ContactName} Region: {c.Region}"));
                }
                else
                {
                    Console.WriteLine("No se encontraron Clientes en la region 'WA'");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion

        #region Exercise 5
        public void ViewExercise5()
        {
            Head(5, "devolver el primer elemento o nulo de una lista de productos donde el ID del producto sea igual a 789");
            Console.WriteLine("Ingrese un Id de Producto");
            string id = Console.ReadLine();

            if (id.IsNum(1,790))
            {
                try
                {
                    Products products = linqLogic.LogicExercise5(Convert.ToInt32(id));
                    if (products != null)
                    {
                        Console.WriteLine($"Id: {products.ProductID}\n" +
                                          $"Nombre: {products.ProductName}\n" +
                                          $"Precio: {products.UnitPrice}");             
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el id buscado");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Digite solo números en 0 y 790");
            }
        }
        #endregion

        #region Exercise 6
        public void ViewExercise6()
        {
            Head(6, "Nombre de Clientes en Mayuscula y en Minuscula");
            try
            {
                List<Ejercicio6Dto> customers = linqLogic.LogicExercise6();
                if (customers != null)
                {
                    customers.ForEach(c => Console.WriteLine($"{c.Upper}  {c.Lower}"));
                }
                else
                {
                    Console.WriteLine("No se encontraron Clientes ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion



        #region Exercise 7 
        public void ViewExercise7()
        {
            Head(7, "Join Customers y Orders - customers.region = WA y orden >  1/1/1997");
            try
            {
                List<Ejercicio7Dto> join = linqLogic.LogicExercise7();
                if (join != null)
                {
                    foreach(var j in join)
                    {
                        Console.WriteLine($"Empresa:{j.Customer.CompanyName}   Region: {j.Customer.Region}   IdOrden:{j.Order.OrderID}   Fecha:{j.Order.OrderDate}"); 
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron Clientes ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion

        #region Exercise 8
        public void ViewExercise8()
        {
            Head(8, "devolver los 3 primeros Clientes de la Región WA");
            try
            {
                List<Customers> customers = linqLogic.LogicExercise4();
                if (customers != null)
                {
                    customers.ForEach(c => Console.WriteLine($"Id: {c.CustomerID} Empresa: {c.CompanyName} Contacto: {c.ContactName} Region: {c.Region}"));
                }
                else
                {
                    Console.WriteLine("No se encontraron Clientes en la region 'WA'");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion

        #region Exercise 9
        public void ViewExercise9()
        {
            Head(9, "devolver lista de productos ordenados por nombre");
            try
            {
                List<Products> products = linqLogic.LogicExercise9();
                if (products != null)
                {
                    products.ForEach(p => Console.WriteLine($"Id: {p.ProductID} Nombre: {p.ProductName} Precio: {p.UnitPrice}"));
                }
                else
                {
                    Console.WriteLine("No se encontraron productos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion

        #region Exercise 10
        public void ViewExercise10()
        {
            Head(10, "devolver lista de productos ordenados por unit in stock de mayor a menor");
            try
            {
                List<Products> products = linqLogic.LogicExercise10();
                if (products != null)
                {
                    products.ForEach(p => Console.WriteLine($"Nombre: {p.ProductName} Unidades en stock: {p.UnitsInStock}"));
                }
                else
                {
                    Console.WriteLine("No se encontraron productos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion

        #region Exercise 11
        public void ViewExercise11()
        {
            Head(11, "devolver las distintas categorías asociadas a los productos");
            try
            {
                List<Categories> categories = linqLogic.LogicExercise11();
                if (categories != null)
                {
                    categories.ForEach(c => Console.WriteLine($"Id: {c.CategoryID}  Nombre: {c.CategoryName}"));
                }
                else
                {
                    Console.WriteLine("No se encontraron categorias");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion
        #region Exercise 12
        public void ViewExercise12()
        {
            Head(12, "devolver el primer elemento de una lista de productos");
            try
            {
                Products products = linqLogic.LogicExercise12();
                if (products != null)
                {
                    Console.WriteLine($"Id: {products.ProductID}"+
                                      $"Nombre: {products.ProductName}"+
                                      $"Precio: {products.UnitPrice}");
                }
                else
                {
                    Console.WriteLine("No se encontraron productos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion

        #region Exercise 13
        public void ViewExercise13()
        {
            Head(13, "devolver los customer con la cantidad de ordenes asociadas");
            try
            {
                List<Ejercicio13Dto> lst = linqLogic.LogicExercise13();
                if (lst != null)
                {
                    foreach(var item in lst)
                    {
                        Console.WriteLine($"Cliente: {item.Customer.CompanyName} Ordenes: {item.Orders}");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron Coincidencias de clientes y # de ordenes");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Atención!! Se presentó un error: {ex.Message}");
            }
        }
        #endregion

    }
}
