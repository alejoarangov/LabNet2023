using Practica03.Entities;

namespace Practica03.Logic
{
    public interface ICategoriesLogic
    {
        Response GetAll();
        Response Create(Categories category);
        Response Update(Categories category);
        Response Delete(int id);
        Response GetByName(string name);
        Response GetByID(int? id);
        bool ValidateProducts(Categories category);
    }
}
