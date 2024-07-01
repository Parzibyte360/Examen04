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
		private void Form1_Load(object sender, EventArgs e)
		{
			dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
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
				txtDeleteRegion.Text = "";
				MessageBox.Show("Registro Exitoso!");
				dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Error! Comunicarse con el Administrador");
				throw;
			}
		}
		private void btnEditRegion_Click(object sender, EventArgs e)
		{
			try
			{
				negocio.Actualizar(Convert.ToInt32(txtEditRegionID.Text), txtEditRegionName.Text);
				MessageBox.Show("Actualización exitosa");
				txtEditRegionID.Text = "";
				txtEditRegionName.Text = "";
				dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Error! Comunicarse con el Administrador");
				throw;
			}
		}
		private void btnDeleteRegion_Click(object sender, EventArgs e)
		{
			try
			{
				negocio.Eliminar(Convert.ToInt32(txtDeleteRegion.Text));
				MessageBox.Show("Eliminación exitosa");
				txtDeleteRegion.Text = "";
				dgvRegion.DataSource = negocio.Listar(btnListarRegion.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Error! Comunicarse con el Administrador");
				throw;
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}