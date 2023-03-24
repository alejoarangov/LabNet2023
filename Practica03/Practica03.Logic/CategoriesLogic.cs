using System;
using System.Collections.Generic;
using System.Linq;
using Practica03.Entities;
using Practica03.Data.Context;

namespace Practica03.Logic
{

    public class CategoriesLogic:ICategoriesLogic
    {
        
        private readonly NorthwindContext context;
        public CategoriesLogic()
        {
            context = new NorthwindContext();
        }


        #region GetAll
        public Response GetAll()
        {
            Response response = new Response();
            try
            {
                response.ListCategory = context.Categories.ToList();
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Message = $"Atencion!! se produjo un error: {ex.Message}";
                response.Success = false;
            }
            return response;
        }
        #endregion

        #region Create 
        public Response Create(Categories category)
        {
            Response response = new Response();
            response = GetByName(category.CategoryName);

            if (!response.Success)
            {
                Categories categories = new Categories()
                {
                    CategoryName = category.CategoryName,
                    Description = category.Description
                };

                try
                {
                    context.Categories.Add(categories);
                    context.SaveChanges();
                    response.Success = true;
                }
                catch (Exception ex)
                {
                    response.Message = $"Atencion!! se produjo un error: {ex.Message}";
                    response.Success = false;
                }
            }
            else
            {
                response.Message = $"La categoria {category.CategoryName} ya existe en la BD";
                response.Success = false;
            }
            return response;
            
        }
        #endregion

        #region Update
        public Response Update(Categories category)
        {
            Response response = new Response();
            response = GetByID(category.CategoryID);

            if (response.Success == true)
            {
                Response respon = new Response();
                respon = GetByName(category.CategoryName);
                if(respon.Success == true)
                {
                    respon.Message = $"La categoria {category.CategoryName} ya existe en la BD";
                    respon.Success = false;
                    return respon;
                }

                response.Category.CategoryName = category.CategoryName;
                response.Category.Description = category.Description;
                try
                {    
                    context.SaveChanges();
                    response.Success = true;
                }
                catch (Exception ex)
                {
                    response.Message = $"Atencion!! se produjo un error: {ex.Message}";
                    response.Success = false;
                }
            }
            return response;
        }
        #endregion

        #region Delete
        public Response Delete(int id)
        {
            Response response = new Response();
            response = GetByID(id);
             
            if (response.Success)
            {
                if(ValidateProducts(response.Category))
                {
                    response.Message = $"La categoria {response.Category.CategoryName} No puede ser borrada porque tiene productos asignados";
                    response.Success= false;
                    return response;
                }
                try
                {
                    context.Categories.Remove(response.Category);
                    context.SaveChanges();
                    response.Success= true;
                }
                catch (Exception ex)
                {
                    response.Message = $"Atencion!! se produjo un error: {ex.Message}";
                }
            }
            else
            {
                response.Message = $"La categoría con id {id} No existe en la BD";
            }
            return response;
        }
        #endregion

        #region GetByName
        public Response GetByName(string name)
        {
            Response response = new Response();
            {
                try
                {
                    response.Category = context.Categories.First(x => x.CategoryName == name);
                    response.Success = true;
                }
                catch 
                {
                    response.Success = false;
                }
            }
           return response;
        }
        #endregion

        #region GetByID
        public Response GetByID(int? id)
        {
            Response response = new Response();
                try
                {
                    response.Category = context.Categories.First(x => x.CategoryID == id);
                    response.Success = true;
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Message = $"Atencion!! No se encontro el ID: {id} -  {ex.Message}";
                }
            return response;
        }
        #endregion

        #region ValidateProducts
        public bool ValidateProducts(Categories category)
        {
            List<Products> products = new List<Products>();
            bool result;
            try
            {
                products = context.Products.Where(x => x.CategoryID == category.CategoryID).ToList();
                result=(products.Count()==0)?false:true;
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
