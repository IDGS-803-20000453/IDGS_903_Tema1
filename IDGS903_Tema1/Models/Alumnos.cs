using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
	public class Alumnos
	{
		public String Nombre { get; set; }
		public int Edad { get; set; }
		public Boolean Activo { get; set; }
		public DateTime Inscrito { get; set; }
	}
}