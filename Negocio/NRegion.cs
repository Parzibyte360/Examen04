using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
	public class NRegion
	{
		NRegion datos = new NRegion();
		public List<Entidad.Region> Listar(string Nombre)
		{
			List<Entidad.Region> result = new List<Entidad.Region>();

			result = datos.Listar(Nombre);
			return result;
		}
	}
}
