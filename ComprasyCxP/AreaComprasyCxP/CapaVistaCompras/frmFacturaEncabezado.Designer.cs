
namespace CapaVistaCompras
{
    partial class frmFacturaEncabezado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaEncabezado));
            this.cboprov2 = new System.Windows.Forms.ComboBox();
            this.txtprov = new System.Windows.Forms.TextBox();
            this.cbmtota = new System.Windows.Forms.ComboBox();
            this.cbmProv = new System.Windows.Forms.ComboBox();
            this.cmbOrdenCompra = new System.Windows.Forms.ComboBox();
            this.txtIDOrdenCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProveedores = new System.Windows.Forms.TextBox();
            this.txtIDFacturaE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboprov2
            // 
            this.cboprov2.FormattingEnabled = true;
            this.cboprov2.Location = new System.Drawing.Point(613, 87);
            this.cboprov2.Name = "cboprov2";
            this.cboprov2.Size = new System.Drawing.Size(22, 21);
            this.cboprov2.TabIndex = 59;
            this.cboprov2.Visible = false;
            // 
            // txtprov
            // 
            this.txtprov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtprov.Location = new System.Drawing.Point(403, 154);
            this.txtprov.Name = "txtprov";
            this.txtprov.Size = new System.Drawing.Size(22, 20);
            this.txtprov.TabIndex = 58;
            this.txtprov.Visible = false;
            // 
            // cbmtota
            // 
            this.cbmtota.FormattingEnabled = true;
            this.cbmtota.Location = new System.Drawing.Point(657, 176);
            this.cbmtota.Name = "cbmtota";
            this.cbmtota.Size = new System.Drawing.Size(17, 21);
            this.cbmtota.TabIndex = 57;
            this.cbmtota.Visible = false;
            // 
            // cbmProv
            // 
            this.cbmProv.FormattingEnabled = true;
            this.cbmProv.Location = new System.Drawing.Point(650, 79);
            this.cbmProv.Name = "cbmProv";
            this.cbmProv.Size = new System.Drawing.Size(24, 21);
            this.cbmProv.TabIndex = 56;
            this.cbmProv.Visible = false;
            // 
            // cmbOrdenCompra
            // 
            this.cmbOrdenCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.cmbOrdenCompra.FormattingEnabled = true;
            this.cmbOrdenCompra.Location = new System.Drawing.Point(257, 127);
            this.cmbOrdenCompra.Name = "cmbOrdenCompra";
            this.cmbOrdenCompra.Size = new System.Drawing.Size(141, 21);
            this.cmbOrdenCompra.TabIndex = 55;
            this.cmbOrdenCompra.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenCompra_SelectedIndexChanged);
            // 
            // txtIDOrdenCompra
            // 
            this.txtIDOrdenCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtIDOrdenCompra.Location = new System.Drawing.Point(636, 39);
            this.txtIDOrdenCompra.Name = "txtIDOrdenCompra";
            this.txtIDOrdenCompra.Size = new System.Drawing.Size(38, 20);
            this.txtIDOrdenCompra.TabIndex = 54;
            this.txtIDOrdenCompra.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(115, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "ID Compra";
            // 
            // txtProveedores
            // 
            this.txtProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtProveedores.Location = new System.Drawing.Point(255, 154);
            this.txtProveedores.Name = "txtProveedores";
            this.txtProveedores.ReadOnly = true;
            this.txtProveedores.Size = new System.Drawing.Size(142, 20);
            this.txtProveedores.TabIndex = 52;
            // 
            // txtIDFacturaE
            // 
            this.txtIDFacturaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtIDFacturaE.Location = new System.Drawing.Point(255, 95);
            this.txtIDFacturaE.Name = "txtIDFacturaE";
            this.txtIDFacturaE.Size = new System.Drawing.Size(142, 20);
            this.txtIDFacturaE.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(115, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Id Factura Encabezado";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCerrar.Location = new System.Drawing.Point(504, 214);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(100, 41);
            this.BtnCerrar.TabIndex = 49;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(580, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 69);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(472, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 69);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtTotal.Location = new System.Drawing.Point(257, 253);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(141, 20);
            this.txtTotal.TabIndex = 46;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtDescripcion.Location = new System.Drawing.Point(256, 216);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(142, 20);
            this.txtDescripcion.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(115, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(115, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(115, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtFecha.Location = new System.Drawing.Point(256, 180);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(142, 20);
            this.txtFecha.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(115, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Factura Encabezado";
            // 
            // frmFacturaEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaCompras.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(710, 330);
            this.Controls.Add(this.cboprov2);
            this.Controls.Add(this.txtprov);
            this.Controls.Add(this.cbmtota);
            this.Controls.Add(this.cbmProv);
            this.Controls.Add(this.cmbOrdenCompra);
            this.Controls.Add(this.txtIDOrdenCompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProveedores);
            this.Controls.Add(this.txtIDFacturaE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFacturaEncabezado";
            this.Text = "2025 Factura Encabezado";
            this.Load += new System.EventHandler(this.frmFacturaEncabezado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboprov2;
        private System.Windows.Forms.TextBox txtprov;
        private System.Windows.Forms.ComboBox cbmtota;
        private System.Windows.Forms.ComboBox cbmProv;
        private System.Windows.Forms.ComboBox cmbOrdenCompra;
        private System.Windows.Forms.TextBox txtIDOrdenCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProveedores;
        private System.Windows.Forms.TextBox txtIDFacturaE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}