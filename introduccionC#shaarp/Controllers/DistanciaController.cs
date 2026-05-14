using System;
using introduccionC_shaarp.Models;
using introduccionC_shaarp.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introduccionC_shaarp.Controllers
{
    public class DistanciaController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Distancia(Distancia modelo)
        {
            modelo.CalcularDistancia();
            return View(modelo);
        }


    }
}