
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
    
    public class CategoriesLogic : ICrudLogic<Categories>
    {
        #region Variable
        private readonly NorthwindContext context;
        #endregion

        #region Builder
        public CategoriesLogic()
        {
            context = new NorthwindContext();
        }
        #endregion

        #region GetAll
        public (List<Categories> lst, string result) GetAll()
        {
            List<Categories> lst = null;
            string result;
            try
            {
                lst = context.Categories.ToList();
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
                        Categories categories = new Categories();
                        categories.CategoryName = name;
                        context.Categories.Add(categories);
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
                    result = $"La categoría '{name}' ya existe en la BD";
                }
            }else
            {
                result = "El campo 'Name' debe digenciarse sólo con texto";
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
                        Categories categories = new Categories();
                        categories = GetByName(nameOld).entity;
                        categories.CategoryName= nameNew;
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
                    result = $"La categoría '{nameOld}' NO existe en la BD";
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
        public (Categories entity, string result) GetByName(string name)
        {
            string result;
            Categories category=null;
            if (ValidateName(name))
            {
                try
                {
                    category = context.Categories.First(x => x.CategoryName == name);
                    result = "Ok";
                }
                catch (Exception ex)
                {
                    result = $"Atencion!! se produjo un error: {ex}";
                }
            }
            else
            {
                result = $"La categoría '{name}' No existe en la BD";
            }
            return (category, result);
        }
        #endregion

        #region Delete
        public (Categories entity, string result) Delete(string name)
        {
            string result;
            Categories category = null;
            if (ValidateName(name))
            {
                try
                {
                    category=GetByName(name).entity;
                    context.Categories.Remove(category);
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
                result = $"La categoría '{name}' No existe en la BD";
            }
            return (category, result);
        }
        #endregion

        #region ValidateName
        public bool ValidateName(string name)
        {
            bool result = false;
            try
            {
                Categories categories = context.Categories.First(x => x.CategoryName == name);
                result = (categories.CategoryName == name) ? true : false;
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
