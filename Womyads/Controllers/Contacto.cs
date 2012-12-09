using Womyads.Models;
using System.Web.Mvc;

namespace Womyads.Controllers
{
    public class ContactoController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Contacto elContacto)
        {
            return View();
        }
    }
}