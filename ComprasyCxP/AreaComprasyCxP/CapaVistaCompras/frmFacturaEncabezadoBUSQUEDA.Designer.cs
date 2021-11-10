
namespace CapaVistaCompras
{
    partial class frmFacturaEncabezadoBUSQUEDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaEncabezadoBUSQUEDA));
            this.cbmprov = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cboProveedorFacturaEncabezado = new System.Windows.Forms.ComboBox();
            this.btnRegresarGESTIONCOMPRAS = new System.Windows.Forms.Button();
            this.txtProveedorGESTIONCOMPRAS = new System.Windows.Forms.TextBox();
            this.BtnBuscarFacturaEncabezado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFacturasEncabezado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasEncabezado)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmprov
            // 
            this.cbmprov.FormattingEnabled = true;
            this.cbmprov.Location = new System.Drawing.Point(509, 55);
            this.cbmprov.Name = "cbmprov";
            this.cbmprov.Size = new System.Drawing.Size(33, 21);
            this.cbmprov.TabIndex = 48;
            this.cbmprov.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.btnActualizar.Image = global::CapaVistaCompras.Properties.Resources.actualizar;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.Location = new System.Drawing.Point(659, 21);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 95);
            this.btnActualizar.TabIndex = 47;
            this.btnActualizar.Text = "Actualizar Facturas Encabezado";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cboProveedorFacturaEncabezado
            // 
            this.cboProveedorFacturaEncabezado.FormattingEnabled = true;
            this.cboProveedorFacturaEncabezado.Location = new System.Drawing.Point(357, 56);
            this.cboProveedorFacturaEncabezado.Name = "cboProveedorFacturaEncabezado";
            this.cboProveedorFacturaEncabezado.Size = new System.Drawing.Size(107, 21);
            this.cboProveedorFacturaEncabezado.TabIndex = 46;
            this.cboProveedorFacturaEncabezado.SelectedIndexChanged += new System.EventHandler(this.cboProveedorFacturaEncabezado_SelectedIndexChanged);
            // 
            // btnRegresarGESTIONCOMPRAS
            // 
            this.btnRegresarGESTIONCOMPRAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.btnRegresarGESTIONCOMPRAS.Location = new System.Drawing.Point(689, 428);
            this.btnRegresarGESTIONCOMPRAS.Name = "btnRegresarGESTIONCOMPRAS";
            this.btnRegresarGESTIONCOMPRAS.Size = new System.Drawing.Size(75, 54);
            this.btnRegresarGESTIONCOMPRAS.TabIndex = 45;
            this.btnRegresarGESTIONCOMPRAS.Text = "Regresar";
            this.btnRegresarGESTIONCOMPRAS.UseVisualStyleBackColor = false;
            // 
            // txtProveedorGESTIONCOMPRAS
            // 
            this.txtProveedorGESTIONCOMPRAS.Location = new System.Drawing.Point(470, 55);
            this.txtProveedorGESTIONCOMPRAS.Name = "txtProveedorGESTIONCOMPRAS";
            this.txtProveedorGESTIONCOMPRAS.Size = new System.Drawing.Size(33, 20);
            this.txtProveedorGESTIONCOMPRAS.TabIndex = 44;
            this.txtProveedorGESTIONCOMPRAS.Visible = false;
            // 
            // BtnBuscarFacturaEncabezado
            // 
            this.BtnBuscarFacturaEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.BtnBuscarFacturaEncabezado.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarFacturaEncabezado.Image")));
            this.BtnBuscarFacturaEncabezado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarFacturaEncabezado.Location = new System.Drawing.Point(548, 21);
            this.BtnBuscarFacturaEncabezado.Name = "BtnBuscarFacturaEncabezado";
            this.BtnBuscarFacturaEncabezado.Size = new System.Drawing.Size(91, 85);
            this.BtnBuscarFacturaEncabezado.TabIndex = 43;
            this.BtnBuscarFacturaEncabezado.Text = "Buscar Factura Encabeado";
            this.BtnBuscarFacturaEncabezado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarFacturaEncabezado.UseVisualStyleBackColor = false;
            this.BtnBuscarFacturaEncabezado.Click += new System.EventHandler(this.BtnBuscarFacturaEncabezado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Facturas Encabezado";
            // 
            // dgvFacturasEncabezado
            // 
            this.dgvFacturasEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturasEncabezado.Location = new System.Drawing.Point(32, 122);
            this.dgvFacturasEncabezado.Name = "dgvFacturasEncabezado";
            this.dgvFacturasEncabezado.Size = new System.Drawing.Size(695, 272);
            this.dgvFacturasEncabezado.TabIndex = 40;
            // 
            // frmFacturaEncabezadoBUSQUEDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaCompras.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(797, 493);
            this.Controls.Add(this.cbmprov);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cboProveedorFacturaEncabezado);
            this.Controls.Add(this.btnRegresarGESTIONCOMPRAS);
            this.Controls.Add(this.txtProveedorGESTIONCOMPRAS);
            this.Controls.Add(this.BtnBuscarFacturaEncabezado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFacturasEncabezado);
            this.Name = "frmFacturaEncabezadoBUSQUEDA";
            this.Text = "2024 Buscar Facturas Encabezado";
            this.Load += new System.EventHandler(this.frmFacturaEncabezadoBUSQUEDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasEncabezado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmprov;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cboProveedorFacturaEncabezado;
        private System.Windows.Forms.Button btnRegresarGESTIONCOMPRAS;
        private System.Windows.Forms.TextBox txtProveedorGESTIONCOMPRAS;
        private System.Windows.Forms.Button BtnBuscarFacturaEncabezado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFacturasEncabezado;
    }
}