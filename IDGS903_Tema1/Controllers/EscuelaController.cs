using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            var alumnos1 = new Alumnos()
            {
                Nombre = "Antonio",
                Edad = 20,
                Activo = false,
                Inscrito = new DateTime(2023,01,15)
            };
            ViewBag.Alumnos = alumnos1;
            return View();
        }
        public ActionResult Registrar(Alumnos alum)
        {
			var alumnos1 = new Alumnos()
			{
				Nombre = "Antonio",
				Edad = 20,
				Activo = false,
				Inscrito = new DateTime(2023, 01, 15)
			};
            alum = alumnos1;

			return View(alum);
        }
		public ActionResult Registrar2(Alumnos alum)
        {
            return View(alum);

        }
    }
}