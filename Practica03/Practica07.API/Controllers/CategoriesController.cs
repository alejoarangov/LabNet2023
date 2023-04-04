using Practica03.Entities;
using Practica03.Logic;
using Practica07.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Practica03.Utils.Extensions;
using System.Web.Http.Cors;

namespace Practica07.API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CategoriesController : ApiController
    {
        private readonly CategoriesLogic categoriesLogic;
        public CategoriesController()
        {
            categoriesLogic = new CategoriesLogic();
        }
        
        public IHttpActionResult Get()
        {
            Response response = categoriesLogic.GetAll();

            if (response.Success == true) { 
                IEnumerable<CategoriesDto> lst = response.ListCategory.Select(x => new CategoriesDto
                {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    Description = x.Description
                });
                return Ok(lst);
            }
            return BadRequest(response.Message);
        }

        public IHttpActionResult Get(int id)
        {
            Response response = categoriesLogic.GetByID(id);

            if (response.Success == true)
            {
                CategoriesDto category = new CategoriesDto();
                category.CategoryID = response.Category.CategoryID;
                category.CategoryName = response.Category.CategoryName;
                category.Description = response.Category.Description;
                
                return Ok(category);
            }
            return BadRequest(response.Message);
        }

        public IHttpActionResult Post(CategoriesDto categoriesDto)
        {
            if (!(categoriesDto.CategoryName.IsText() && categoriesDto.Description.IsText()))
                return BadRequest("Digite solo texto");

            Categories category = new Categories();
            Response response= new Response();
            
            category.CategoryName = categoriesDto.CategoryName;
            category.Description = categoriesDto.Description;
            response = categoriesLogic.Create(category);

            if (response.Success)
                return Ok();
            return BadRequest(response.Message);
        }

        public IHttpActionResult Put(CategoriesDto categoriesDto)
        {
            if (!(categoriesDto.CategoryName.IsText() && categoriesDto.Description.IsText()))
                return BadRequest("Digite solo texto");

            Categories category = new Categories();
            Response response = new Response();

            category.CategoryID = categoriesDto.CategoryID;
            category.CategoryName = categoriesDto.CategoryName;
            category.Description = categoriesDto.Description;
            response = categoriesLogic.Update(category);

            if (response.Success)
                return Ok();
            return BadRequest(response.Message);
        }

        public IHttpActionResult Delete(int id)
        {
            Response response = new Response();
            response = categoriesLogic.Delete(id);

            if (response.Success)
                return Ok();
            return BadRequest(response.Message);
        }

    }
}