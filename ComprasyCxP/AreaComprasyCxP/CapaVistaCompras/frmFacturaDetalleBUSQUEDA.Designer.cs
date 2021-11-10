
namespace CapaVistaCompras
{
    partial class frmFacturaDetalleBUSQUEDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaDetalleBUSQUEDA));
            this.cbopr = new System.Windows.Forms.ComboBox();
            this.cboProductoFacturaDetalle = new System.Windows.Forms.ComboBox();
            this.btnRegresarGESTIONCOMPRAS = new System.Windows.Forms.Button();
            this.txtProveedorGESTIONCOMPRAS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgFacturasDetalle = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBuscarFacturaDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFacturasDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // cbopr
            // 
            this.cbopr.FormattingEnabled = true;
            this.cbopr.Location = new System.Drawing.Point(563, 52);
            this.cbopr.Name = "cbopr";
            this.cbopr.Size = new System.Drawing.Size(25, 21);
            this.cbopr.TabIndex = 60;
            this.cbopr.Visible = false;
            // 
            // cboProductoFacturaDetalle
            // 
            this.cboProductoFacturaDetalle.FormattingEnabled = true;
            this.cboProductoFacturaDetalle.Location = new System.Drawing.Point(404, 52);
            this.cboProductoFacturaDetalle.Name = "cboProductoFacturaDetalle";
            this.cboProductoFacturaDetalle.Size = new System.Drawing.Size(107, 21);
            this.cboProductoFacturaDetalle.TabIndex = 58;
            this.cboProductoFacturaDetalle.SelectedIndexChanged += new System.EventHandler(this.cboProductoFacturaDetalle_SelectedIndexChanged);
            // 
            // btnRegresarGESTIONCOMPRAS
            // 
            this.btnRegresarGESTIONCOMPRAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.btnRegresarGESTIONCOMPRAS.Location = new System.Drawing.Point(750, 435);
            this.btnRegresarGESTIONCOMPRAS.Name = "btnRegresarGESTIONCOMPRAS";
            this.btnRegresarGESTIONCOMPRAS.Size = new System.Drawing.Size(75, 54);
            this.btnRegresarGESTIONCOMPRAS.TabIndex = 57;
            this.btnRegresarGESTIONCOMPRAS.Text = "Regresar";
            this.btnRegresarGESTIONCOMPRAS.UseVisualStyleBackColor = false;
            // 
            // txtProveedorGESTIONCOMPRAS
            // 
            this.txtProveedorGESTIONCOMPRAS.Location = new System.Drawing.Point(517, 51);
            this.txtProveedorGESTIONCOMPRAS.Name = "txtProveedorGESTIONCOMPRAS";
            this.txtProveedorGESTIONCOMPRAS.Size = new System.Drawing.Size(33, 20);
            this.txtProveedorGESTIONCOMPRAS.TabIndex = 56;
            this.txtProveedorGESTIONCOMPRAS.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Facturas Detalle";
            // 
            // dvgFacturasDetalle
            // 
            this.dvgFacturasDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFacturasDetalle.Location = new System.Drawing.Point(37, 122);
            this.dvgFacturasDetalle.Name = "dvgFacturasDetalle";
            this.dvgFacturasDetalle.Size = new System.Drawing.Size(798, 272);
            this.dvgFacturasDetalle.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.button1.Image = global::CapaVistaCompras.Properties.Resources.actualizar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(711, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 85);
            this.button1.TabIndex = 59;
            this.button1.Text = "Actualizar Factura Detalle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBuscarFacturaDetalle
            // 
            this.BtnBuscarFacturaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.BtnBuscarFacturaDetalle.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarFacturaDetalle.Image")));
            this.BtnBuscarFacturaDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarFacturaDetalle.Location = new System.Drawing.Point(594, 15);
            this.BtnBuscarFacturaDetalle.Name = "BtnBuscarFacturaDetalle";
            this.BtnBuscarFacturaDetalle.Size = new System.Drawing.Size(91, 85);
            this.BtnBuscarFacturaDetalle.TabIndex = 55;
            this.BtnBuscarFacturaDetalle.Text = "Buscar Factura Detalle";
            this.BtnBuscarFacturaDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarFacturaDetalle.UseVisualStyleBackColor = false;
            this.BtnBuscarFacturaDetalle.Click += new System.EventHandler(this.BtnBuscarFacturaDetalle_Click);
            // 
            // frmFacturaDetalleBUSQUEDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaCompras.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(866, 530);
            this.Controls.Add(this.cbopr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboProductoFacturaDetalle);
            this.Controls.Add(this.btnRegresarGESTIONCOMPRAS);
            this.Controls.Add(this.txtProveedorGESTIONCOMPRAS);
            this.Controls.Add(this.BtnBuscarFacturaDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgFacturasDetalle);
            this.Name = "frmFacturaDetalleBUSQUEDA";
            this.Text = "2022 Buscar Factura Detalle";
            this.Load += new System.EventHandler(this.frmFacturaDetalleBUSQUEDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFacturasDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbopr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboProductoFacturaDetalle;
        private System.Windows.Forms.Button btnRegresarGESTIONCOMPRAS;
        private System.Windows.Forms.TextBox txtProveedorGESTIONCOMPRAS;
        private System.Windows.Forms.Button BtnBuscarFacturaDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgFacturasDetalle;
    }
}