using Practica03.Entities;
using Practica03.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03.UI
{
    public class ViewCategories 
    {
        #region Variable
        private readonly CategoriesLogic categoriesLogic;
        #endregion

        #region Builder
        public ViewCategories()
        {
            categoriesLogic = new CategoriesLogic();
        }
        #endregion

        #region GetAll
        public void GetAll()
        {
            Console.WriteLine("Lista de categorías");

            var categories = categoriesLogic.GetAll();
            if (categories.result == "Ok")
            {
                foreach (var category in categories.lst)
                {
                    Console.WriteLine($"-ID: {category.CategoryID}   -Name: {category.CategoryName}   -Descripción: {category.Description}");
                }
            }
            else
            {
                Console.WriteLine(categories.result);
            }
        }
        #endregion

        #region Create
        public void Create()
        {
            Console.WriteLine("Digite el nombre de la nueva categoría");
            string name = Console.ReadLine();

            string result = categoriesLogic.Create(name);
            Console.WriteLine(result);
        }
        #endregion

        #region GetByName
        public void GetByName()
        {
            Console.WriteLine("Digite el nombre de la categoría que quiere buscar");
            string name = Console.ReadLine();

            var category = categoriesLogic.GetByName(name);
            if (category.result == "Ok")
            {
                Console.WriteLine($"Name : {category.entity.CategoryName}\n"
                                 +$"Description : {category.entity.Description}\n"
                                 +$"ID : {category.entity.CategoryID}");
            }
            else
            {
                Console.WriteLine(category.result);
            }
        }
        #endregion

        #region Update
        public void Update()
        {
            Console.WriteLine("Digite el nombre de la categoría que quiere modificar");
            string nameOld = Console.ReadLine();

            Console.WriteLine("Digite el nuevo nombre de la categoría");
            string nameNew = Console.ReadLine();

            string result = categoriesLogic.Update(nameOld, nameNew);
            Console.WriteLine(result);
        }
        #endregion

        #region Delete
        public void Delete()
        {
            Console.WriteLine("Digite el nombre de la categoría que quiere borrar");
            string name = Console.ReadLine();

            string result = categoriesLogic.Delete(name).result;
            Console.WriteLine(result);
        }
        #endregion

    }
}
