using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
	public partial class Form1 : Form
	{
		NRegion negocio = new NRegion();
		public Form1()
		{

			InitializeComponent();
		}

		private void btnListarRegion_Click(object sender, EventArgs e)
		{
			dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnInsertRegion_Click(object sender, EventArgs e)
		{
			try
			{
				negocio.Insertar(txtRegionName.Text);
				MessageBox.Show("Registro Exitoso!");
			}
			catch (Exception)
			{
				MessageBox.Show("Error! Comunicarse con el Administrador");
				throw;
			}

		}
	}
}