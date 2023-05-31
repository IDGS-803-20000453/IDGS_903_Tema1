using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
	public class LeerPalabra1
	{
		public Array LeerPalabra()
		{
			Array palData = null;
			var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
			if (File.Exists(archivo))
			{
				palData = File.ReadAllLines(archivo);

			}
			return palData;

		}
	}
}