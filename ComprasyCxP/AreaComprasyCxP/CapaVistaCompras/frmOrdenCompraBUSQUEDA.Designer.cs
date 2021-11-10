
namespace CapaVistaCompras
{
    partial class frmOrdenCompraBUSQUEDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenCompraBUSQUEDA));
            this.cboprov = new System.Windows.Forms.ComboBox();
            this.cboProveedorOrdenCompra = new System.Windows.Forms.ComboBox();
            this.btnRegresarGESTIONCOMPRAS = new System.Windows.Forms.Button();
            this.txtProveedorGESTIONCOMPRAS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHistorialCompras = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBuscarCompraGESTIONCOMPRA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // cboprov
            // 
            this.cboprov.FormattingEnabled = true;
            this.cboprov.Location = new System.Drawing.Point(507, 48);
            this.cboprov.Name = "cboprov";
            this.cboprov.Size = new System.Drawing.Size(37, 21);
            this.cboprov.TabIndex = 35;
            this.cboprov.Visible = false;
            // 
            // cboProveedorOrdenCompra
            // 
            this.cboProveedorOrdenCompra.FormattingEnabled = true;
            this.cboProveedorOrdenCompra.Location = new System.Drawing.Point(355, 48);
            this.cboProveedorOrdenCompra.Name = "cboProveedorOrdenCompra";
            this.cboProveedorOrdenCompra.Size = new System.Drawing.Size(107, 21);
            this.cboProveedorOrdenCompra.TabIndex = 34;
            this.cboProveedorOrdenCompra.SelectedIndexChanged += new System.EventHandler(this.cboProveedorOrdenCompra_SelectedIndexChanged);
            // 
            // btnRegresarGESTIONCOMPRAS
            // 
            this.btnRegresarGESTIONCOMPRAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.btnRegresarGESTIONCOMPRAS.Location = new System.Drawing.Point(750, 450);
            this.btnRegresarGESTIONCOMPRAS.Name = "btnRegresarGESTIONCOMPRAS";
            this.btnRegresarGESTIONCOMPRAS.Size = new System.Drawing.Size(75, 54);
            this.btnRegresarGESTIONCOMPRAS.TabIndex = 33;
            this.btnRegresarGESTIONCOMPRAS.Text = "Regresar";
            this.btnRegresarGESTIONCOMPRAS.UseVisualStyleBackColor = false;
            this.btnRegresarGESTIONCOMPRAS.Click += new System.EventHandler(this.btnRegresarGESTIONCOMPRAS_Click);
            // 
            // txtProveedorGESTIONCOMPRAS
            // 
            this.txtProveedorGESTIONCOMPRAS.Location = new System.Drawing.Point(468, 47);
            this.txtProveedorGESTIONCOMPRAS.Name = "txtProveedorGESTIONCOMPRAS";
            this.txtProveedorGESTIONCOMPRAS.Size = new System.Drawing.Size(33, 20);
            this.txtProveedorGESTIONCOMPRAS.TabIndex = 32;
            this.txtProveedorGESTIONCOMPRAS.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ordenes de Compras";
            // 
            // dgvHistorialCompras
            // 
            this.dgvHistorialCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCompras.Location = new System.Drawing.Point(61, 109);
            this.dgvHistorialCompras.Name = "dgvHistorialCompras";
            this.dgvHistorialCompras.Size = new System.Drawing.Size(649, 329);
            this.dgvHistorialCompras.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.button1.Image = global::CapaVistaCompras.Properties.Resources.actualizar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(647, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 96);
            this.button1.TabIndex = 36;
            this.button1.Text = "Actualizar Orden de Compra";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBuscarCompraGESTIONCOMPRA
            // 
            this.BtnBuscarCompraGESTIONCOMPRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(146)))));
            this.BtnBuscarCompraGESTIONCOMPRA.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarCompraGESTIONCOMPRA.Image")));
            this.BtnBuscarCompraGESTIONCOMPRA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarCompraGESTIONCOMPRA.Location = new System.Drawing.Point(550, 18);
            this.BtnBuscarCompraGESTIONCOMPRA.Name = "BtnBuscarCompraGESTIONCOMPRA";
            this.BtnBuscarCompraGESTIONCOMPRA.Size = new System.Drawing.Size(91, 85);
            this.BtnBuscarCompraGESTIONCOMPRA.TabIndex = 31;
            this.BtnBuscarCompraGESTIONCOMPRA.Text = "Buscar Orden de Compra";
            this.BtnBuscarCompraGESTIONCOMPRA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarCompraGESTIONCOMPRA.UseVisualStyleBackColor = false;
            this.BtnBuscarCompraGESTIONCOMPRA.Click += new System.EventHandler(this.BtnBuscarCompraGESTIONCOMPRA_Click);
            // 
            // frmOrdenCompraBUSQUEDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaCompras.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(834, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboprov);
            this.Controls.Add(this.cboProveedorOrdenCompra);
            this.Controls.Add(this.btnRegresarGESTIONCOMPRAS);
            this.Controls.Add(this.txtProveedorGESTIONCOMPRAS);
            this.Controls.Add(this.BtnBuscarCompraGESTIONCOMPRA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorialCompras);
            this.Name = "frmOrdenCompraBUSQUEDA";
            this.Text = "2020 Buscar Ordenes de Compra";
            this.Load += new System.EventHandler(this.frmOrdenCompraBUSQUEDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboprov;
        private System.Windows.Forms.ComboBox cboProveedorOrdenCompra;
        private System.Windows.Forms.Button btnRegresarGESTIONCOMPRAS;
        private System.Windows.Forms.TextBox txtProveedorGESTIONCOMPRAS;
        private System.Windows.Forms.Button BtnBuscarCompraGESTIONCOMPRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHistorialCompras;
    }
}