using Womyads.Models;
using System.Web.Mvc;

namespace Womyads.Controllers
{
    public class RegistroController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Registro elRegistro)
        {
            return View();
        }
    }
}
