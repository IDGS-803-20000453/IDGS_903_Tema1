using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
	public class OperaBas
	{
		public double Num1 { get; set; }
		public double Num2 { get; set; }
		public double Res { get; set; }

		public string tipo { get; set; }

		public double Sumar() { return (Num1 + Num2); }
		public double Restar() { return (Num1 - Num2); }
		public double Multilicar() { return (Num1 * Num2); }
		public double Dividir() { return (Num1 / Num2); }

		public double Operas()
		{
			double r = 0;
			if (tipo == "suma")
			{
				r = Sumar();
			}

			if (tipo == "resta")
			{
				r = Restar();
			}

			if (tipo == "multi")
			{
				r = Multilicar();
			}
			if (tipo == "divi")
			{
				r = Dividir();
			}
			return r;
		}
	}
}