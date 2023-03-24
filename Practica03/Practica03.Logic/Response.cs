using Practica03.Entities;
using System.Collections.Generic;

namespace Practica03.Logic
{
    public class Response
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public Categories Category { get; set; }
        public List<Categories> ListCategory { get; set; }
    }
}
