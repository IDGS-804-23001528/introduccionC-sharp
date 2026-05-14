using introduccionC_shaarp.Models;
using System.Web.Mvc;

namespace introduccionC_shaarp.Controllers
{
    public class MultiplicacionController : Controller
    {
        public ActionResult Multiplicacion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Multiplicacion(Multiplicacion modelo)
        {
            modelo.CalcularMultiplicacion();
            return View(modelo);
        }
    }
}