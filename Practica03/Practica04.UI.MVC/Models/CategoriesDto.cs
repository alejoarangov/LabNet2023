using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practica06.UI.MVC.Models
{
    public class CategoriesDto
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Ojo.. el nombre es obligatorio")]
        [StringLength(15,ErrorMessage ="Heyy.. solo 15 caracteres")]
        [Display(Name="Nombre")]
        public string CategoryName { get; set; }

        
        [Display(Name = "Descripción")]
        [StringLength(30, ErrorMessage = "Heyy.. solo 30 caracteres")]
        public string Description { get; set; }
        public List<CategoriesDto> ListCategories { get; set; }
        public bool IsError { get; set; }
        public string Error { get; set; }
    }
}