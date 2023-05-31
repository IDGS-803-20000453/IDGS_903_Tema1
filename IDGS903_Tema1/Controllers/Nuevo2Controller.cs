using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class Nuevo2Controller : Controller
    {
        // GET: Nuevo2
        public ActionResult Ventana2()
        {
            return View();
        }
		public ActionResult Calculos(string n1, string n2, string operacion)
		{
			double res = 0;
			if (!string.IsNullOrEmpty(n1) && !string.IsNullOrEmpty(n2))
			{
				double num1 = double.Parse(n1);
				double num2 = double.Parse(n2);
				if (operacion == "suma")
				{
					res = num1 + num2;
				}
				else if (operacion == "resta")
				{
					res = num1 - num2;
				}
				else if (operacion == "multiplicacion")
				{
					res = num1 * num2;
				}
				else if (operacion == "division")
				{
					res = num1 / num2;
				}
			}
			ViewBag.Resultado = res;
			return View();
		}

		public ActionResult Ventana3(OperaBas op)
		{
			op.Sumar();
			var model = new OperaBas();
			model.Res = op.Res;
			
			return View(model);
		}

		public ActionResult calcular(OperaBas op)
		{
			var model = new OperaBas();

			model.Res = op.Operas();

			return View(model);
		}






	}
}