using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Region = Entidad.Region;

namespace Datos
{
	public class DRegion
	{
		public List<Entidad.Region> Listar(string Nombre)
		{
			List<Entidad.Region> regions = new List<Entidad.Region>();

			using (var connection = new SqlConnection(Conexion.cadena))
			{
				//Usar el procedimiento almacenado
				SqlCommand cmd = new SqlCommand("sp_ReadRegions", connection);
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

					int RegionId = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;
					string RegionName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";

					regions.Add(new Region { RegionId = RegionId, RegionName = RegionName });


				}
				reader.Close();
			}
			return regions;
		}
		public void Insertar(string Nombre)
		{
			using (var connection = new SqlConnection(Conexion.cadena))
			{
				connection.Open();
				SqlCommand command = new SqlCommand("sp_CreateRegion", connection);
				command.CommandType = CommandType.StoredProcedure;

				SqlParameter parameter = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
				parameter.Value = Nombre;
				command.Parameters.Add(parameter);

				command.ExecuteNonQuery();
			}
		}
		public void Actualizar(int RegionId, string RegionName)
		{
			using (var connection = new SqlConnection(Conexion.cadena))
			{
				connection.Open();
				SqlCommand command = new SqlCommand("sp_UpdateRegion", connection);
				command.CommandType = CommandType.StoredProcedure;

				SqlParameter parameter1 = new SqlParameter("@RegionId", SqlDbType.Int);
				parameter1.Value = RegionId;
				command.Parameters.Add(parameter1);

				SqlParameter parameter2 = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
				parameter2.Value = RegionName;
				command.Parameters.Add(parameter2);

				command.ExecuteNonQuery();
			}
		}
		
		public void Eliminar(int RegionId)
		{
			using (var connection = new SqlConnection(Conexion.cadena))
			{
				connection.Open();
				SqlCommand command = new SqlCommand("sp_DeleteRegion", connection);
				command.CommandType = CommandType.StoredProcedure;

				SqlParameter parameter1 = new SqlParameter("@RegionId", SqlDbType.Int);
				parameter1.Value = RegionId;
				command.Parameters.Add(parameter1);

				command.ExecuteNonQuery();
			}
		}
	}
}
