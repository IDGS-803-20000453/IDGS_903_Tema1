using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class PalabrasController : Controller
    {
        // GET: Palabras
        public ActionResult Registrar()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Diccionario dic)
        {
			var op = new GuardaService();
			op.GuardarPalabraArchivo(dic);
			return View();
		}

        public ActionResult LeerPalabra()
        {
            var pal = new LeerPalabra1();
            ViewBag.Palabras = pal.LeerPalabra();
            return View();
        }

		public ActionResult Traductor(Traductor traductor)
		{
			TempData["Resultado"] = traductor.traducir();
			return View(traductor);
		}
	}
}