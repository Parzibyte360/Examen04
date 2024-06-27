using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
	public class DRegion
	{
		public List<Entidad.Region> Listar(string Nombre)
		{
			List<Entidad.Region> roles = new List<Entidad.Region>();

			using (var connection = new SqlConnection(Conexion.cadena))
			{
				//Usar el procedimiento almacenado
				SqlCommand cmd = new SqlCommand("USP_GetRoles", connection);
				cmd.CommandType = CommandType.StoredProcedure;


				//Enviar los parámetros
				SqlParameter parameter = new SqlParameter("@RoleName", SqlDbType.VarChar, 50);
				parameter.Value = Nombre;
				cmd.Parameters.Add(parameter);

				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();

				//Recorrer el data reader
				while (reader.Read())
				{

					int RoleID = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;
					string RoleName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";

					roles.Add(new Entidad.Region { RegionId = RegionId, RegionName = RegionName });


				}
				reader.Close();
			}
			return roles;

		}
	}
}
