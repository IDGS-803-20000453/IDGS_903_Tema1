using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult MuestraPulques()
        {
            var pulquesVenta=new PulquesServices();
            var model = pulquesVenta.ObtenerPulque();

            return View(model);
        }

		public ActionResult MuestraPulques2()
		{
            TempData["nombres"] = "Mario Brothers";
			var pulquesVenta = new PulquesServices();
			var model = pulquesVenta.ObtenerPulque();

			return View(model);
		}
        public JsonResult Index()
        {
            var pulque1 = new Pulques() { Nombre = "pulqueMango", Descripcion = "Algo" };

           // return Content("Leonardo Escobar ASP.NET");
            return Json(pulque1,JsonRequestBehavior.AllowGet);
        }
        public ActionResult Vista()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "pulque Mango",
                Descripcion = "mango",
                Caducidad = new DateTime(2023, 11, 3)
            };
            ViewBag.pulques = pulque1;
            return View();
        }

        public ActionResult Vista2()
        {
            ViewBag.saludo = "Hola mundo";
            ViewBag.fecha = DateTime.Now;
            ViewData["Nombre"] = "Leo";

            string nombre = "";
            if(TempData.ContainsKey("nombre"))
            {
                nombre = TempData["nombres"] as string;

            }
            ViewBag.nombreNuevo = nombre;
            return View();
        }
	}
}