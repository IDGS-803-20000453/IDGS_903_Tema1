using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TriangulosController : Controller
    {
		// GET: Triangulos
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Calcular(Triangulos cor)
		{
			cor.calcular();
			ViewBag.Resulado = cor;
			return View(cor);
		}


	}
}