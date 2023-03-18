using Practica04.Data.Context;
using Practica04.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica04.Logic
{
    public class LinqLogic
    {
        #region Variable
        private readonly NorthwindContext context;
        #endregion

        #region Builder
        public LinqLogic()
        {
            context = new NorthwindContext();
        }
        #endregion

        #region Exercise 1 - Devolver objeto customer
        public Customers LogicExercise1(string idCustomer)
        {
            Customers customers = null;
            try
            {
                customers = context.Customers.FirstOrDefault(c => c.CustomerID.Equals(idCustomer));
            }
            catch (Exception ex) 
            {
                throw (ex);
            }
            return customers;
        }
        #endregion



        #region Exercise 2 - Devolver todos los productos sin stock
        public List<Products> LogicExercise2()
        {
            List<Products> products = null;
            try
            {
               products=context.Products.Where(p => p.UnitsInStock == 0).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return products;
        }
        #endregion


        #region Exercise 3 - devolver productos que tienen stock y que cuestan más de 3 por unidad
        public List<Products> LogicExercise3()
        {
            List<Products> products = null;
            try
            {
                products = context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice>3).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return products;
        }
        #endregion

        #region Exercise 4 - devolver todos los customers de la Región WA
        public List<Customers> LogicExercise4()
        {
            List<Customers> customers = null;
            try
            {
                customers = context.Customers.Where(c => c.Region=="WA").ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return customers;
        }
        #endregion


        #region Exercise 5 - devolver el 1er ó nulo de lista productos -  ID producto =789
        public Products LogicExercise5(int id)
        {
            Products products = null;
            try
            {
                products = context.Products.FirstOrDefault(p => p.ProductID == id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return products;
        }
        #endregion

        #region Exercise 6 - nombre de Customers. en Mayuscula y en Minuscula.
        public List<Ejercicio6Dto> LogicExercise6()
        {
            List<Ejercicio6Dto> customers = null;
            try
            {
                customers = (from c in context.Customers
                                 select new Ejercicio6Dto()
                                 {
                                     Upper = c.CompanyName.ToString().ToUpper(),
                                     Lower = c.CompanyName.ToString().ToLower()
                                 }).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return customers;
        }
        #endregion

        #region Exercise 7 - Join Customers y Orders - customers.region = WA y orden >  1/1/1997
        public List<Ejercicio7Dto> LogicExercise7()
        {
            List<Ejercicio7Dto> join = null;
            try
            {
                DateTime fechaInicial = new DateTime(1997,1,1);

                join = (from c in context.Customers
                        join o in context.Orders
                        on c.CustomerID equals o.CustomerID
                        where c.Region=="WA" && o.OrderDate> fechaInicial
                        select new Ejercicio7Dto()
                            {
                                Customer=c,
                                Order=o
                            }).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return join;
        }
        #endregion


        #region Exercise 8 - devolver los 3 primeros customers de la Región WA
        public List<Customers> LogicExercise8()
        {
            List<Customers> customers = null;
            try
            {
                customers = (from c in context.Customers
                             where c.Region=="WA"
                             select c
                             ).Take(3).ToList();    
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return customers;
        }
        #endregion

        #region Exercise 9 - devolver lista de productos ordenados por nombre
        public List<Products> LogicExercise9()
        {
            List<Products> products = null;
            try
            {
                products = (from p in context.Products
                             orderby p.ProductName
                             select p
                             ).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return products;
        }
        #endregion

        #region Exercise 10 - devolver lista de productos ordenados por unit in stock de mayor a menor
        public List<Products> LogicExercise10()
        {
            List<Products> products = null;
            try
            {
                products = (from p in context.Products
                            orderby  p.UnitsInStock descending
                            select p
                             ).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return products;
        }
        #endregion

        #region Exercise 11 - devolver las distintas categorías asociadas a los productos
        public List<Categories> LogicExercise11()
        {
            List<Categories> categories = null;
            try
            {
                categories = (from p in context.Products
                              join c in context.Categories
                              on p.CategoryID equals c.CategoryID
                              where c.CategoryID == p.CategoryID
                              group c by c.CategoryID into groupC
                              select groupC.FirstOrDefault()
                             ).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return categories;
        }
        #endregion

        #region Exercise 12 - devolver el primer elemento de una lista de productos
        public Products LogicExercise12()
        {
            Products products = null;
            try
            {
                products = context.Products.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return products;
        }
        #endregion

        #region Exercise 13 - devolver los customer con la cantidad de ordenes asociadas
        public List<Ejercicio13Dto> LogicExercise13()
        {
            List<Ejercicio13Dto> lst = null;
            try
            {
                lst = (from c in context.Customers
                        join o in context.Orders
                        on c.CustomerID equals o.CustomerID
                        
                        select new Ejercicio13Dto()
                        {
                            Customer = c,
                            Orders = o.CustomerID.Count(x=>x.Equals(c.CustomerID))
                        }).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return lst;
        }
        #endregion

    }
}
