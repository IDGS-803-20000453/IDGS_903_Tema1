using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
	public class Traductor
	{
		public string Opcion { get;  set; }
		public string textWord { get; set; }

		public string traducir()
		{
			LeerPalabra1 leerPalabra1 = new LeerPalabra1();
			var data = leerPalabra1.LeerPalabra();
			var word = "";
			if (data != null) { 

				foreach (string line in data)
			{
				switch (Opcion)
				{
					case "ingles":
						word = line.Split('-')[0];
						if (textWord != null && word == textWord.ToLower())
						{
							return line.Split('-')[1];
						}
						break;

					case "espagnol":
						word = line.Split('-')[1];
						if (textWord != null && word == textWord.ToLower())
						{
							return line.Split('-')[0];
						}
						break;
				}
			}
			}
			if (word != "")
			{
				return "Palabra no registrada";

			}
			return "";

		}

	}
}