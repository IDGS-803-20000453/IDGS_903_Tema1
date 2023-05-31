using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
	public class Triangulos
	{
		public double x1 { get; set; }
		public double x2 { get; set; }
		public double x3 { get; set; }
		public double y1 { get; set; }
		public double y2 { get; set; }
		public double y3 { get; set; }
		public double lado1 { get; set; }
		public double lado2 { get; set; }
		public double lado3 { get; set; }
		public string tipo { get; set; }
		public double area { get; set; }

		public void calcular()
		{
			lado1 = TruncateToThreeDecimals(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
			lado2 = TruncateToThreeDecimals(Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)));
			lado3 = TruncateToThreeDecimals(Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)));

			double p = lado1 + lado2 + lado3;
			double sp = p / 2;
			double muti = sp * (sp - lado1) * (sp - lado2) * (sp - lado3);
			area = Math.Round(TruncateToThreeDecimals(Math.Sqrt(muti)));

			// Comprobación para verificar si es un triángulo
			if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
			{
				if (Math.Round(lado1, 3) == Math.Round(lado2, 3) && Math.Round(lado2, 3) == Math.Round(lado3, 3))
				{
					tipo = "Equilátero";
				}
				else if (Math.Round(lado1, 3) == Math.Round(lado2, 3) || Math.Round(lado2, 3) == Math.Round(lado3, 3) || Math.Round(lado1, 3) == Math.Round(lado3, 3))
				{
					tipo = "Isósceles";
				}
				else
				{
					tipo = "Escaleno";
				}
			}
			else
			{
				tipo = "No es un triángulo";
			}
		}


		private double TruncateToThreeDecimals(double value)
		{
			return Math.Truncate(value * 1000) / 1000;
		}
	}

}