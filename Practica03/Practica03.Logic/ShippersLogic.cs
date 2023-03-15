
using Practica03.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica03.Utils.Extensions;
using Practica03.Entities;
using Practica03.Data.Context;
using System.Xml.Linq;

namespace Practica03.Logic
{

    public class ShippersLogic:ICrudLogic<Shippers>
    {
        #region Variable
        private readonly NorthwindContext context;
        #endregion

        #region Builder
        public ShippersLogic()
        {
            context = new NorthwindContext();
        }
        #endregion

        #region GetAll
        public (List<Shippers> lst, string result) GetAll()
        {
            List<Shippers> lst = null;
            string result;
            try
            {
                lst = context.Shippers.ToList();
                result = "Ok";
            }
            catch (Exception ex)
            {
                result = $"Atencion!! se produjo un error: {ex}";
            }
            return (lst, result);
        }
        #endregion

        #region Create 
        public string Create(string name)
        {
            string result;
            if (name.IsText())
            {
                if (!ValidateName(name))
                {
                    try
                    {
                        Shippers shippers = new Shippers();
                        shippers.CompanyName = name;
                        context.Shippers.Add(shippers);
                        context.SaveChanges();
                        result = "Ok";
                    }
                    catch (Exception ex)
                    {
                        result = $"Atencion!! se produjo un error: {ex}";
                    }
                }
                else
                {
                    result = $"El Distribuidor '{name}' ya existe en la BD";
                }
            }
            else
            {
                result = "El campo debe digenciarse sólo con texto";
            }
            return result;
        }
        #endregion

        #region Update
        public string Update(string nameOld, string nameNew)
        {
            string result;
            if (nameOld.IsText() && nameNew.IsText())
            {
                if (ValidateName(nameOld))
                {
                    try
                    {
                        Shippers shippers = new Shippers();
                        shippers = GetByName(nameOld).entity;
                        shippers.CompanyName = nameNew;
                        context.SaveChanges();
                        result = "Ok";
                    }
                    catch (Exception ex)
                    {
                        result = $"Atencion!! se produjo un error: {ex}";
                    }
                }
                else
                {
                    result = $"El distribuidor '{nameOld}' NO existe en la BD";
                }
            }
            else
            {
                result = "Los campos deben digenciarse sólo con texto";
            }
            return result;
        }
        #endregion

        #region GetByName
        public (Shippers entity, string result) GetByName(string name)
        {
            string result;
            Shippers shippers = null;
            if (ValidateName(name))
            {
                try
                {
                    shippers = context.Shippers.First(x => x.CompanyName == name);
                    result = "Ok";
                }
                catch (Exception ex)
                {
                    result = $"Atencion!! se produjo un error: {ex}";
                }
            }
            else
            {
                result = $"El distribuidor'{name}' No existe en la BD";
            }
            return (shippers, result);
        }
        #endregion

        #region Delete
        public (Shippers entity, string result) Delete(string name)
        {
            string result;
            Shippers shippers = null;
            if (ValidateName(name))
            {
                try
                {
                    shippers = GetByName(name).entity;
                    context.Shippers.Remove(shippers);
                    context.SaveChanges();
                    result = "Ok";
                }
                catch (Exception ex)
                {
                    result = $"Atencion!! se produjo un error: {ex}";
                }
            }
            else
            {
                result = $"El distribuidor '{name}' No existe en la BD";
            }
            return (shippers, result);
        }
        #endregion

        #region ValidateName
        public bool ValidateName(string name)
        {
            bool result = false;
            try
            {
                Shippers shippers = context.Shippers.First(x => x.CompanyName == name);
                result = (shippers.CompanyName == name) ? true : false;
            }
            catch
            {
                result = false;
            }
            return result;
        }
        #endregion

    }
}
