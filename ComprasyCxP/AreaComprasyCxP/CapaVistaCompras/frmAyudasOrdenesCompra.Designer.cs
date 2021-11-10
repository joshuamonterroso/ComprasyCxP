
namespace CapaVistaCompras
{
    partial class frmAyudasOrdenesCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAyudas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "AYUDAS";
            // 
            // btnAyudas
            // 
            this.btnAyudas.Location = new System.Drawing.Point(167, 123);
            this.btnAyudas.Name = "btnAyudas";
            this.btnAyudas.Size = new System.Drawing.Size(113, 42);
            this.btnAyudas.TabIndex = 1;
            this.btnAyudas.Text = "ABRIR AYUDAS";
            this.btnAyudas.UseVisualStyleBackColor = true;
            this.btnAyudas.Click += new System.EventHandler(this.btnAyudas_Click);
            // 
            // frmAyudasOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaCompras.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(396, 264);
            this.Controls.Add(this.btnAyudas);
            this.Controls.Add(this.label1);
            this.Name = "frmAyudasOrdenesCompra";
            this.Text = "2029 Ayudas Ordenes de Compra y Facturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyudas;
    }
}