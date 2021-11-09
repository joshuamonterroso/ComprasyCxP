
namespace CapaVistaSeguridadHSC
{
	partial class frmPermisos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermisos));
            this.bnUsuario = new System.Windows.Forms.RadioButton();
            this.rbPerfil = new System.Windows.Forms.RadioButton();
            this.labelEntidad = new System.Windows.Forms.Label();
            this.labelenti = new System.Windows.Forms.Label();
            this.labelaplicacion = new System.Windows.Forms.Label();
            this.cbxEntidad = new System.Windows.Forms.ComboBox();
            this.cbxAplicacion = new System.Windows.Forms.ComboBox();
            this.Escritura = new System.Windows.Forms.CheckBox();
            this.Lectura = new System.Windows.Forms.CheckBox();
            this.Modificacion = new System.Windows.Forms.CheckBox();
            this.Eliminacion = new System.Windows.Forms.CheckBox();
            this.Impresion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelidentidad = new System.Windows.Forms.Label();
            this.labelidaplicacion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgPermisosUA = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgPermisosPA = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbi = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbe = new System.Windows.Forms.Label();
            this.lbel = new System.Windows.Forms.Label();
            this.lbm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisosUA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisosPA)).BeginInit();
            this.SuspendLayout();
            // 
            // bnUsuario
            // 
            this.bnUsuario.AutoSize = true;
            this.bnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.bnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnUsuario.Location = new System.Drawing.Point(33, 58);
            this.bnUsuario.Name = "bnUsuario";
            this.bnUsuario.Size = new System.Drawing.Size(82, 24);
            this.bnUsuario.TabIndex = 0;
            this.bnUsuario.TabStop = true;
            this.bnUsuario.Text = "Usuario";
            this.bnUsuario.UseVisualStyleBackColor = false;
            this.bnUsuario.CheckedChanged += new System.EventHandler(this.bnUsuario_CheckedChanged);
            // 
            // rbPerfil
            // 
            this.rbPerfil.AutoSize = true;
            this.rbPerfil.BackColor = System.Drawing.Color.Transparent;
            this.rbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerfil.Location = new System.Drawing.Point(110, 58);
            this.rbPerfil.Name = "rbPerfil";
            this.rbPerfil.Size = new System.Drawing.Size(62, 24);
            this.rbPerfil.TabIndex = 1;
            this.rbPerfil.TabStop = true;
            this.rbPerfil.Text = "Perfil";
            this.rbPerfil.UseVisualStyleBackColor = false;
            this.rbPerfil.CheckedChanged += new System.EventHandler(this.rbPerfil_CheckedChanged);
            // 
            // labelEntidad
            // 
            this.labelEntidad.AutoSize = true;
            this.labelEntidad.BackColor = System.Drawing.Color.Transparent;
            this.labelEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntidad.Location = new System.Drawing.Point(30, 32);
            this.labelEntidad.Name = "labelEntidad";
            this.labelEntidad.Size = new System.Drawing.Size(132, 20);
            this.labelEntidad.TabIndex = 2;
            this.labelEntidad.Text = "Elija una Entidad:";
            // 
            // labelenti
            // 
            this.labelenti.AutoSize = true;
            this.labelenti.BackColor = System.Drawing.Color.Transparent;
            this.labelenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelenti.Location = new System.Drawing.Point(33, 98);
            this.labelenti.Name = "labelenti";
            this.labelenti.Size = new System.Drawing.Size(64, 20);
            this.labelenti.TabIndex = 3;
            this.labelenti.Text = "Entidad";
            // 
            // labelaplicacion
            // 
            this.labelaplicacion.AutoSize = true;
            this.labelaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelaplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaplicacion.Location = new System.Drawing.Point(233, 98);
            this.labelaplicacion.Name = "labelaplicacion";
            this.labelaplicacion.Size = new System.Drawing.Size(98, 20);
            this.labelaplicacion.TabIndex = 4;
            this.labelaplicacion.Text = "Aplicaciones";
            // 
            // cbxEntidad
            // 
            this.cbxEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEntidad.FormattingEnabled = true;
            this.cbxEntidad.Location = new System.Drawing.Point(33, 121);
            this.cbxEntidad.Name = "cbxEntidad";
            this.cbxEntidad.Size = new System.Drawing.Size(121, 28);
            this.cbxEntidad.TabIndex = 5;
            this.cbxEntidad.SelectedIndexChanged += new System.EventHandler(this.cbxEntidad_SelectedIndexChanged);
            // 
            // cbxAplicacion
            // 
            this.cbxAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAplicacion.FormattingEnabled = true;
            this.cbxAplicacion.Location = new System.Drawing.Point(236, 121);
            this.cbxAplicacion.Name = "cbxAplicacion";
            this.cbxAplicacion.Size = new System.Drawing.Size(121, 28);
            this.cbxAplicacion.TabIndex = 6;
            this.cbxAplicacion.SelectedIndexChanged += new System.EventHandler(this.cbxAplicacion_SelectedIndexChanged);
            // 
            // Escritura
            // 
            this.Escritura.AutoSize = true;
            this.Escritura.BackColor = System.Drawing.Color.Transparent;
            this.Escritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escritura.Location = new System.Drawing.Point(33, 212);
            this.Escritura.Name = "Escritura";
            this.Escritura.Size = new System.Drawing.Size(91, 24);
            this.Escritura.TabIndex = 7;
            this.Escritura.Text = "Escritura";
            this.Escritura.UseVisualStyleBackColor = false;
            this.Escritura.CheckedChanged += new System.EventHandler(this.Escritura_CheckedChanged);
            // 
            // Lectura
            // 
            this.Lectura.AutoSize = true;
            this.Lectura.BackColor = System.Drawing.Color.Transparent;
            this.Lectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lectura.Location = new System.Drawing.Point(156, 212);
            this.Lectura.Name = "Lectura";
            this.Lectura.Size = new System.Drawing.Size(82, 24);
            this.Lectura.TabIndex = 8;
            this.Lectura.Text = "Lectura";
            this.Lectura.UseVisualStyleBackColor = false;
            this.Lectura.CheckedChanged += new System.EventHandler(this.Lectura_CheckedChanged);
            // 
            // Modificacion
            // 
            this.Modificacion.AutoSize = true;
            this.Modificacion.BackColor = System.Drawing.Color.Transparent;
            this.Modificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificacion.Location = new System.Drawing.Point(261, 212);
            this.Modificacion.Name = "Modificacion";
            this.Modificacion.Size = new System.Drawing.Size(116, 24);
            this.Modificacion.TabIndex = 9;
            this.Modificacion.Text = "Modificación";
            this.Modificacion.UseVisualStyleBackColor = false;
            this.Modificacion.CheckedChanged += new System.EventHandler(this.Modificacion_CheckedChanged);
            // 
            // Eliminacion
            // 
            this.Eliminacion.AutoSize = true;
            this.Eliminacion.BackColor = System.Drawing.Color.Transparent;
            this.Eliminacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminacion.Location = new System.Drawing.Point(73, 256);
            this.Eliminacion.Name = "Eliminacion";
            this.Eliminacion.Size = new System.Drawing.Size(108, 24);
            this.Eliminacion.TabIndex = 10;
            this.Eliminacion.Text = "Eliminación";
            this.Eliminacion.UseVisualStyleBackColor = false;
            this.Eliminacion.CheckedChanged += new System.EventHandler(this.Eliminacion_CheckedChanged);
            // 
            // Impresion
            // 
            this.Impresion.AutoSize = true;
            this.Impresion.BackColor = System.Drawing.Color.Transparent;
            this.Impresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impresion.Location = new System.Drawing.Point(196, 256);
            this.Impresion.Name = "Impresion";
            this.Impresion.Size = new System.Drawing.Size(98, 24);
            this.Impresion.TabIndex = 11;
            this.Impresion.Text = "Impresión";
            this.Impresion.UseVisualStyleBackColor = false;
            this.Impresion.CheckedChanged += new System.EventHandler(this.Impresion_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elija los permisos que desea asignar:";
            // 
            // labelidentidad
            // 
            this.labelidentidad.AutoSize = true;
            this.labelidentidad.BackColor = System.Drawing.Color.Transparent;
            this.labelidentidad.Location = new System.Drawing.Point(172, 124);
            this.labelidentidad.Name = "labelidentidad";
            this.labelidentidad.Size = new System.Drawing.Size(10, 13);
            this.labelidentidad.TabIndex = 13;
            this.labelidentidad.Text = "-";
            this.labelidentidad.Visible = false;
            // 
            // labelidaplicacion
            // 
            this.labelidaplicacion.AutoSize = true;
            this.labelidaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelidaplicacion.Location = new System.Drawing.Point(375, 124);
            this.labelidaplicacion.Name = "labelidaplicacion";
            this.labelidaplicacion.Size = new System.Drawing.Size(10, 13);
            this.labelidaplicacion.TabIndex = 14;
            this.labelidaplicacion.Text = "-";
            this.labelidaplicacion.Visible = false;
            this.labelidaplicacion.Click += new System.EventHandler(this.labelidaplicacion_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(249, 332);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 29);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtgPermisosUA
            // 
            this.dtgPermisosUA.AllowUserToAddRows = false;
            this.dtgPermisosUA.AllowUserToDeleteRows = false;
            this.dtgPermisosUA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisosUA.Location = new System.Drawing.Point(411, 65);
            this.dtgPermisosUA.Name = "dtgPermisosUA";
            this.dtgPermisosUA.ReadOnly = true;
            this.dtgPermisosUA.Size = new System.Drawing.Size(546, 150);
            this.dtgPermisosUA.TabIndex = 16;
            this.dtgPermisosUA.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Permisos de Usuario en Aplicación:";
            // 
            // dtgPermisosPA
            // 
            this.dtgPermisosPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisosPA.Location = new System.Drawing.Point(411, 256);
            this.dtgPermisosPA.Name = "dtgPermisosPA";
            this.dtgPermisosPA.Size = new System.Drawing.Size(546, 150);
            this.dtgPermisosPA.TabIndex = 18;
            this.dtgPermisosPA.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgPermisosPA_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Permisos de Perfil en Aplicación:";
            // 
            // lbi
            // 
            this.lbi.AutoSize = true;
            this.lbi.Location = new System.Drawing.Point(99, 332);
            this.lbi.Name = "lbi";
            this.lbi.Size = new System.Drawing.Size(35, 13);
            this.lbi.TabIndex = 20;
            this.lbi.Text = "label4";
            this.lbi.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(140, 332);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "label5";
            this.lbl.Visible = false;
            // 
            // lbe
            // 
            this.lbe.AutoSize = true;
            this.lbe.Location = new System.Drawing.Point(99, 358);
            this.lbe.Name = "lbe";
            this.lbe.Size = new System.Drawing.Size(35, 13);
            this.lbe.TabIndex = 22;
            this.lbe.Text = "label6";
            this.lbe.Visible = false;
            // 
            // lbel
            // 
            this.lbel.AutoSize = true;
            this.lbel.Location = new System.Drawing.Point(140, 358);
            this.lbel.Name = "lbel";
            this.lbel.Size = new System.Drawing.Size(35, 13);
            this.lbel.TabIndex = 23;
            this.lbel.Text = "label7";
            this.lbel.Visible = false;
            // 
            // lbm
            // 
            this.lbm.AutoSize = true;
            this.lbm.Location = new System.Drawing.Point(193, 332);
            this.lbm.Name = "lbm";
            this.lbm.Size = new System.Drawing.Size(35, 13);
            this.lbm.TabIndex = 24;
            this.lbm.Text = "label8";
            this.lbm.Visible = false;
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(983, 418);
            this.Controls.Add(this.lbm);
            this.Controls.Add(this.lbel);
            this.Controls.Add(this.lbe);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgPermisosPA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgPermisosUA);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelidaplicacion);
            this.Controls.Add(this.labelidentidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Impresion);
            this.Controls.Add(this.Eliminacion);
            this.Controls.Add(this.Modificacion);
            this.Controls.Add(this.Lectura);
            this.Controls.Add(this.Escritura);
            this.Controls.Add(this.cbxAplicacion);
            this.Controls.Add(this.cbxEntidad);
            this.Controls.Add(this.labelaplicacion);
            this.Controls.Add(this.labelenti);
            this.Controls.Add(this.labelEntidad);
            this.Controls.Add(this.rbPerfil);
            this.Controls.Add(this.bnUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0008 Asiganción de Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisosUA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisosPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton bnUsuario;
		private System.Windows.Forms.RadioButton rbPerfil;
		private System.Windows.Forms.Label labelEntidad;
		private System.Windows.Forms.Label labelenti;
		private System.Windows.Forms.Label labelaplicacion;
		private System.Windows.Forms.ComboBox cbxEntidad;
		private System.Windows.Forms.ComboBox cbxAplicacion;
		private System.Windows.Forms.CheckBox Escritura;
		private System.Windows.Forms.CheckBox Lectura;
		private System.Windows.Forms.CheckBox Modificacion;
		private System.Windows.Forms.CheckBox Eliminacion;
		private System.Windows.Forms.CheckBox Impresion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelidentidad;
		private System.Windows.Forms.Label labelidaplicacion;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridView dtgPermisosUA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dtgPermisosPA;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbi;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Label lbe;
		private System.Windows.Forms.Label lbel;
		private System.Windows.Forms.Label lbm;
	}
}