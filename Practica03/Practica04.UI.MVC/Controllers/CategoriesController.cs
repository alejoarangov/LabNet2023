using Practica03.Entities;
using Practica03.Logic;
using Practica06.UI.MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace Practica04.UI.MVC.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly CategoriesLogic categoriesLogic;
        public CategoriesController()
        {
            categoriesLogic = new CategoriesLogic();
        }

        [HttpGet]
        public ActionResult Index(Response respon)
        {
            Response response = categoriesLogic.GetAll();
            List<Categories> categories= response.ListCategory;

            CategoriesDto categoriesDto = new CategoriesDto();
            if (respon.Message!= null) categoriesDto.Error = respon.Message;
            
            categoriesDto.ListCategories = categories.Select(x => new CategoriesDto
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToList();
            return View(categoriesDto);
        }

        [HttpGet]
        public ActionResult Category(CategoriesDto categoriesDto, Response respon, int? id = 0) 
        {
            Response response = new Response();
            response = categoriesLogic.GetByID(id.Value);
            if (response.Success) 
            {

                response = categoriesLogic.GetByID(id.Value);
                CategoriesDto categoryDto = new CategoriesDto
                {
                    CategoryID = response.Category.CategoryID,
                    CategoryName = response.Category.CategoryName,
                    Description = response.Category.Description
                };
                return View(categoryDto);
            }
            if (respon.Message != null) categoriesDto.Error = respon.Message;
            if (categoriesDto == null) categoriesDto = new CategoriesDto();

            return View(categoriesDto);
        }


        [HttpPost]
        public ActionResult Save(CategoriesDto categoriesDto)
        {
            if (ModelState.IsValid)
            {
                Response response = new Response();
                Categories category = new Categories();

                if (categoriesDto.CategoryID == 0)
                {
                    category.CategoryName = categoriesDto.CategoryName;
                    category.Description = categoriesDto.Description;
                    response = categoriesLogic.Create(category);
                }
                else
                {
                    category.CategoryID = categoriesDto.CategoryID;
                    category.CategoryName = categoriesDto.CategoryName;
                    category.Description = categoriesDto.Description;
                    response = categoriesLogic.Update(category);
                }

                if (response.Success)
                    return RedirectToAction("Index");
                else
                    return RedirectToAction("Category", response);
            }
            return RedirectToAction("Category", categoriesDto);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Response response = new Response();
            response = categoriesLogic.Delete(id);

            if (response.Success)
                return RedirectToAction("Index");
            else
                return RedirectToAction("Index", response);
        }

    }
}