namespace Presentacion
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnListarRegion = new Button();
			dgvRegion = new DataGridView();
			RegionId = new DataGridViewTextBoxColumn();
			RegionName = new DataGridViewTextBoxColumn();
			Enabled = new DataGridViewTextBoxColumn();
			txtRegionName = new TextBox();
			btnInsertRegion = new Button();
			label = new Label();
			((System.ComponentModel.ISupportInitialize)dgvRegion).BeginInit();
			SuspendLayout();
			// 
			// btnListarRegion
			// 
			btnListarRegion.Location = new Point(585, 108);
			btnListarRegion.Name = "btnListarRegion";
			btnListarRegion.Size = new Size(138, 29);
			btnListarRegion.TabIndex = 0;
			btnListarRegion.Text = "Listar";
			btnListarRegion.UseVisualStyleBackColor = true;
			btnListarRegion.Click += btnListarRegion_Click;
			// 
			// dgvRegion
			// 
			dgvRegion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvRegion.Columns.AddRange(new DataGridViewColumn[] { RegionId, RegionName, Enabled });
			dgvRegion.Location = new Point(182, 152);
			dgvRegion.Name = "dgvRegion";
			dgvRegion.RowHeadersWidth = 51;
			dgvRegion.RowTemplate.Height = 29;
			dgvRegion.Size = new Size(541, 188);
			dgvRegion.TabIndex = 1;
			// 
			// RegionId
			// 
			RegionId.DataPropertyName = "RegionId";
			RegionId.HeaderText = "RegionId";
			RegionId.MinimumWidth = 6;
			RegionId.Name = "RegionId";
			RegionId.Width = 125;
			// 
			// RegionName
			// 
			RegionName.DataPropertyName = "RegionName";
			RegionName.HeaderText = "RegionName";
			RegionName.MinimumWidth = 6;
			RegionName.Name = "RegionName";
			RegionName.Width = 125;
			// 
			// Enabled
			// 
			Enabled.DataPropertyName = "Enabled";
			Enabled.HeaderText = "Enabled";
			Enabled.MinimumWidth = 6;
			Enabled.Name = "Enabled";
			Enabled.Width = 125;
			// 
			// txtRegionName
			// 
			txtRegionName.Location = new Point(366, 67);
			txtRegionName.Name = "txtRegionName";
			txtRegionName.Size = new Size(189, 23);
			txtRegionName.TabIndex = 2;
			// 
			// btnInsertRegion
			// 
			btnInsertRegion.Location = new Point(585, 63);
			btnInsertRegion.Name = "btnInsertRegion";
			btnInsertRegion.Size = new Size(138, 29);
			btnInsertRegion.TabIndex = 3;
			btnInsertRegion.Text = "Crear Región";
			btnInsertRegion.UseVisualStyleBackColor = true;
			btnInsertRegion.Click += btnInsertRegion_Click;
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label.Location = new Point(182, 70);
			label.Name = "label";
			label.Size = new Size(162, 15);
			label.TabIndex = 4;
			label.Text = "Nombre de la Region a Crear:";
			label.Click += label1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(900, 450);
			Controls.Add(label);
			Controls.Add(btnInsertRegion);
			Controls.Add(txtRegionName);
			Controls.Add(dgvRegion);
			Controls.Add(btnListarRegion);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dgvRegion).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnListarRegion;
		private DataGridView dgvRegion;
		private DataGridViewTextBoxColumn RegionId;
		private DataGridViewTextBoxColumn RegionName;
		private DataGridViewTextBoxColumn Enabled;
		private TextBox txtRegionName;
		private Button btnInsertRegion;
		private Label label;
	}
}