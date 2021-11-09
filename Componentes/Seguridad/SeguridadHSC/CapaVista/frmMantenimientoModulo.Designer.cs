
namespace CapaVistaSeguridadHSC
{
    partial class frmMantenimientoModulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoModulo));
            this.perfilTabla = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.btnInhabilitado = new System.Windows.Forms.RadioButton();
            this.btnHabilitado = new System.Windows.Forms.RadioButton();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNombreaplicacion = new System.Windows.Forms.Label();
            this.labelIdaplicacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.perfilTabla)).BeginInit();
            this.gbxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // perfilTabla
            // 
            this.perfilTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.perfilTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perfilTabla.Location = new System.Drawing.Point(12, 307);
            this.perfilTabla.Name = "perfilTabla";
            this.perfilTabla.Size = new System.Drawing.Size(634, 183);
            this.perfilTabla.TabIndex = 38;
            this.perfilTabla.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.perfilTabla_RowHeaderMouseClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(514, 114);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(514, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(514, 51);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(363, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 20);
            this.textBox3.TabIndex = 34;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 2;
            // 
            // gbxEstado
            // 
            this.gbxEstado.BackColor = System.Drawing.Color.Transparent;
            this.gbxEstado.Controls.Add(this.btnInhabilitado);
            this.gbxEstado.Controls.Add(this.btnHabilitado);
            this.gbxEstado.Location = new System.Drawing.Point(157, 187);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(200, 100);
            this.gbxEstado.TabIndex = 33;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado Aplicacion";
            // 
            // btnInhabilitado
            // 
            this.btnInhabilitado.AutoSize = true;
            this.btnInhabilitado.Location = new System.Drawing.Point(115, 41);
            this.btnInhabilitado.Name = "btnInhabilitado";
            this.btnInhabilitado.Size = new System.Drawing.Size(79, 17);
            this.btnInhabilitado.TabIndex = 5;
            this.btnInhabilitado.TabStop = true;
            this.btnInhabilitado.Text = "Inhabilitado";
            this.btnInhabilitado.UseVisualStyleBackColor = true;
            this.btnInhabilitado.CheckedChanged += new System.EventHandler(this.btnInhabilitado_CheckedChanged);
            // 
            // btnHabilitado
            // 
            this.btnHabilitado.AutoSize = true;
            this.btnHabilitado.Location = new System.Drawing.Point(7, 41);
            this.btnHabilitado.Name = "btnHabilitado";
            this.btnHabilitado.Size = new System.Drawing.Size(72, 17);
            this.btnHabilitado.TabIndex = 4;
            this.btnHabilitado.TabStop = true;
            this.btnHabilitado.Text = "Habilitado";
            this.btnHabilitado.UseVisualStyleBackColor = true;
            this.btnHabilitado.CheckedChanged += new System.EventHandler(this.btnHabilitado_CheckedChanged);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(514, 22);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelNombreaplicacion
            // 
            this.labelNombreaplicacion.AutoSize = true;
            this.labelNombreaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreaplicacion.Location = new System.Drawing.Point(52, 85);
            this.labelNombreaplicacion.Name = "labelNombreaplicacion";
            this.labelNombreaplicacion.Size = new System.Drawing.Size(85, 13);
            this.labelNombreaplicacion.TabIndex = 32;
            this.labelNombreaplicacion.Text = "Nombre Módulo:";
            // 
            // labelIdaplicacion
            // 
            this.labelIdaplicacion.AutoSize = true;
            this.labelIdaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelIdaplicacion.Location = new System.Drawing.Point(52, 47);
            this.labelIdaplicacion.Name = "labelIdaplicacion";
            this.labelIdaplicacion.Size = new System.Drawing.Size(59, 13);
            this.labelIdaplicacion.TabIndex = 31;
            this.labelIdaplicacion.Text = "ID Módulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(52, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Descripción Módulo:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 20);
            this.textBox4.TabIndex = 3;
            // 
            // frmMantenimientoModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 504);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.perfilTabla);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombreaplicacion);
            this.Controls.Add(this.labelIdaplicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0012 Mantenimiento Módulo";
            ((System.ComponentModel.ISupportInitialize)(this.perfilTabla)).EndInit();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView perfilTabla;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.RadioButton btnInhabilitado;
        private System.Windows.Forms.RadioButton btnHabilitado;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNombreaplicacion;
        private System.Windows.Forms.Label labelIdaplicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
    }
}