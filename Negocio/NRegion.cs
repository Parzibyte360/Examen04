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
		DRegion datos = new DRegion();
		public List<Entidad.Region> Listar(string Nombre)
		{
			List<Entidad.Region> result = new List<Entidad.Region>();

			result = datos.Listar(Nombre);
			return result;
		}
		public void Insertar(string Nombre)
		{
			datos.Insertar(Nombre);
		}
		public void Actualizar(int RegionId, string RegionName)
		{
			datos.Actualizar(RegionId, RegionName);
		}

		public void Eliminar(int RegionId)
		{
			datos.Eliminar(RegionId);
		}
	}
}