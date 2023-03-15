using Practica03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Practica03.Logic
{
    internal interface ICrudLogic<T>
    {
        (List<T> lst, string result) GetAll();
        string Create(string name);
        string Update(string nameOld, string nameNew);
        (T entity, string result) GetByName(string name);
        (T entity, string result) Delete(string name);
        bool ValidateName(string name);
    }
}
