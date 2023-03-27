using System.Web.Mvc;

namespace Practica07.API.Controllers
{
    public class RickMortyController : Controller
    {
        // GET: RickMorty
        public ActionResult Index()
        {
            return View();
        }
    }
}