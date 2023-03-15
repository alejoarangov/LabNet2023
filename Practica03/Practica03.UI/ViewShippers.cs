using Practica03.Entities;
using Practica03.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03.UI
{
    public class ViewShippers
    {
        #region Variable
        private readonly ShippersLogic shippersLogic;
        #endregion

        #region Builder
        public ViewShippers()
        {
            shippersLogic = new ShippersLogic();
        }
        #endregion

        #region GetAll
        public void GetAll()
        {
            Console.WriteLine("Lista de Distribuidores");

            var shippers = shippersLogic.GetAll();
            if (shippers.result == "Ok")
            {
                foreach (var shipper in shippers.lst)
                {
                    Console.WriteLine($"-ID: {shipper.ShipperID}   -Name: {shipper.CompanyName}   -Phone: {shipper.Phone}");
                }
            }
            else
            {
                Console.WriteLine(shippers.result);
            }
        }
        #endregion

        #region Create
        public void Create()
        {
            Console.WriteLine("Digite el nombre del nuevo Distribuidor");
            string name = Console.ReadLine();

            string result = shippersLogic.Create(name);
            Console.WriteLine(result);
        }
        #endregion

        #region GetByName
        public void GetByName()
        {
            Console.WriteLine("Digite el nombre del Distribuidor que quiere buscar");
            string name = Console.ReadLine();

            var shippers = shippersLogic.GetByName(name);
            if (shippers.result == "Ok")
            {
                Console.WriteLine($"Name : {shippers.entity.CompanyName}\n"
                                 + $"Phone : {shippers.entity.Phone}\n"
                                 + $"ID : {shippers.entity.ShipperID}");
            }
            else
            {
                Console.WriteLine(shippers.result);
            }
        }
        #endregion

        #region Update
        public void Update()
        {
            Console.WriteLine("Digite el nombre del Distribuidor que quiere modificar");
            string nameOld = Console.ReadLine();

            Console.WriteLine("Digite el nuevo nombre del Distribuidor");
            string nameNew = Console.ReadLine();

            string result = shippersLogic.Update(nameOld, nameNew);
            Console.WriteLine(result);
        }
        #endregion

        #region Delete
        public void Delete()
        {
            Console.WriteLine("Digite el nombre del Distribuidor que quiere borrar");
            string name = Console.ReadLine();

            string result = shippersLogic.Delete(name).result;
            Console.WriteLine(result);
        }
        #endregion

    }
}