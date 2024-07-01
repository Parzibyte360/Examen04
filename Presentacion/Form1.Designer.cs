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
			label1 = new Label();
			txtEditRegionID = new TextBox();
			txtEditRegionName = new TextBox();
			label2 = new Label();
			btnEditRegion = new Button();
			groupBox1 = new GroupBox();
			txtDeleteRegion = new TextBox();
			label3 = new Label();
			btnDeleteRegion = new Button();
			groupBox2 = new GroupBox();
			groupBox3 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dgvRegion).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// btnListarRegion
			// 
			btnListarRegion.Location = new Point(548, 43);
			btnListarRegion.Name = "btnListarRegion";
			btnListarRegion.Size = new Size(106, 55);
			btnListarRegion.TabIndex = 0;
			btnListarRegion.Text = "Listar";
			btnListarRegion.UseVisualStyleBackColor = true;
			btnListarRegion.Click += btnListarRegion_Click;
			// 
			// dgvRegion
			// 
			dgvRegion.BackgroundColor = SystemColors.ControlLightLight;
			dgvRegion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvRegion.Columns.AddRange(new DataGridViewColumn[] { RegionId, RegionName, Enabled });
			dgvRegion.Location = new Point(12, 282);
			dgvRegion.Name = "dgvRegion";
			dgvRegion.RowHeadersWidth = 51;
			dgvRegion.RowTemplate.Height = 29;
			dgvRegion.Size = new Size(753, 353);
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
			txtRegionName.ForeColor = SystemColors.Desktop;
			txtRegionName.Location = new Point(192, 38);
			txtRegionName.Name = "txtRegionName";
			txtRegionName.Size = new Size(189, 23);
			txtRegionName.TabIndex = 2;
			// 
			// btnInsertRegion
			// 
			btnInsertRegion.ForeColor = SystemColors.Desktop;
			btnInsertRegion.Location = new Point(17, 67);
			btnInsertRegion.Name = "btnInsertRegion";
			btnInsertRegion.Size = new Size(364, 29);
			btnInsertRegion.TabIndex = 3;
			btnInsertRegion.Text = "Crear Región";
			btnInsertRegion.UseVisualStyleBackColor = true;
			btnInsertRegion.Click += btnInsertRegion_Click;
			// 
			// label
			// 
			label.AutoSize = true;
			label.ForeColor = SystemColors.Desktop;
			label.Location = new Point(17, 42);
			label.Name = "label";
			label.Size = new Size(169, 15);
			label.TabIndex = 4;
			label.Text = "Nombre de la Region a Crear:";
			label.Click += label1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 39);
			label1.Name = "label1";
			label1.Size = new Size(142, 15);
			label1.TabIndex = 5;
			label1.Text = "ID de la Region a editar: ";
			// 
			// txtEditRegionID
			// 
			txtEditRegionID.Location = new Point(192, 31);
			txtEditRegionID.Name = "txtEditRegionID";
			txtEditRegionID.Size = new Size(170, 23);
			txtEditRegionID.TabIndex = 6;
			// 
			// txtEditRegionName
			// 
			txtEditRegionName.Location = new Point(192, 60);
			txtEditRegionName.Name = "txtEditRegionName";
			txtEditRegionName.Size = new Size(170, 23);
			txtEditRegionName.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 62);
			label2.Name = "label2";
			label2.Size = new Size(170, 15);
			label2.TabIndex = 7;
			label2.Text = "Nuevo Nombre de la Región: ";
			// 
			// btnEditRegion
			// 
			btnEditRegion.Location = new Point(16, 96);
			btnEditRegion.Name = "btnEditRegion";
			btnEditRegion.Size = new Size(346, 29);
			btnEditRegion.TabIndex = 9;
			btnEditRegion.Text = "Editar Región";
			btnEditRegion.UseVisualStyleBackColor = true;
			btnEditRegion.Click += btnEditRegion_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.PowderBlue;
			groupBox1.Controls.Add(label);
			groupBox1.Controls.Add(btnInsertRegion);
			groupBox1.Controls.Add(txtRegionName);
			groupBox1.ForeColor = SystemColors.ActiveCaptionText;
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(392, 106);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "Crear Región";
			groupBox1.Enter += groupBox1_Enter;
			// 
			// txtDeleteRegion
			// 
			txtDeleteRegion.Location = new Point(192, 28);
			txtDeleteRegion.Name = "txtDeleteRegion";
			txtDeleteRegion.Size = new Size(142, 23);
			txtDeleteRegion.TabIndex = 12;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(10, 31);
			label3.Name = "label3";
			label3.Size = new Size(154, 15);
			label3.TabIndex = 11;
			label3.Text = "ID de la Region a eliminar: ";
			// 
			// btnDeleteRegion
			// 
			btnDeleteRegion.Location = new Point(10, 65);
			btnDeleteRegion.Name = "btnDeleteRegion";
			btnDeleteRegion.Size = new Size(324, 29);
			btnDeleteRegion.TabIndex = 13;
			btnDeleteRegion.Text = "Eliminar Region";
			btnDeleteRegion.UseVisualStyleBackColor = true;
			btnDeleteRegion.Click += btnDeleteRegion_Click;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.PowderBlue;
			groupBox2.Controls.Add(btnEditRegion);
			groupBox2.Controls.Add(txtEditRegionName);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(txtEditRegionID);
			groupBox2.Controls.Add(btnListarRegion);
			groupBox2.Controls.Add(label1);
			groupBox2.Location = new Point(12, 124);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(753, 152);
			groupBox2.TabIndex = 14;
			groupBox2.TabStop = false;
			groupBox2.Text = "Editar Región";
			// 
			// groupBox3
			// 
			groupBox3.BackColor = Color.PowderBlue;
			groupBox3.Controls.Add(btnDeleteRegion);
			groupBox3.Controls.Add(txtDeleteRegion);
			groupBox3.Controls.Add(label3);
			groupBox3.Location = new Point(419, 12);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(346, 106);
			groupBox3.TabIndex = 15;
			groupBox3.TabStop = false;
			groupBox3.Text = "Eliminar Región";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(775, 665);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(dgvRegion);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dgvRegion).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
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
		private Label label1;
		private TextBox txtEditRegionID;
		private TextBox txtEditRegionName;
		private Label label2;
		private Button btnEditRegion;
		private GroupBox groupBox1;
		private TextBox txtDeleteRegion;
		private Label label3;
		private Button btnDeleteRegion;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
	}
}