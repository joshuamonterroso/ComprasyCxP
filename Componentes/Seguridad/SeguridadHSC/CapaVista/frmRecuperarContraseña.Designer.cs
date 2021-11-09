
namespace CapaVistaSeguridadHSC
{
    partial class frmRecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarContraseña));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtConfirmacion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnPasswordn = new System.Windows.Forms.Button();
            this.btnConfirmacion = new System.Windows.Forms.Button();
            this.btnConfirmacionN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(28, 125);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.Location = new System.Drawing.Point(28, 173);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(145, 20);
            this.lblNuevaContraseña.TabIndex = 0;
            this.lblNuevaContraseña.Text = "Nueva Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(198, 122);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(211, 28);
            this.cbxUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(198, 173);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(211, 26);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.Location = new System.Drawing.Point(198, 220);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(211, 26);
            this.txtConfirmacion.TabIndex = 2;
            this.txtConfirmacion.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(318, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(198, 318);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPassword.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.see__1_;
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(415, 178);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(19, 19);
            this.btnPassword.TabIndex = 6;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnPasswordn
            // 
            this.btnPasswordn.BackColor = System.Drawing.Color.Transparent;
            this.btnPasswordn.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.hide__1_;
            this.btnPasswordn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasswordn.FlatAppearance.BorderSize = 0;
            this.btnPasswordn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordn.Location = new System.Drawing.Point(415, 178);
            this.btnPasswordn.Name = "btnPasswordn";
            this.btnPasswordn.Size = new System.Drawing.Size(19, 19);
            this.btnPasswordn.TabIndex = 5;
            this.btnPasswordn.UseVisualStyleBackColor = false;
            this.btnPasswordn.Visible = false;
            this.btnPasswordn.Click += new System.EventHandler(this.btnPasswordN_Click);
            // 
            // btnConfirmacion
            // 
            this.btnConfirmacion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmacion.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.see__1_;
            this.btnConfirmacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmacion.FlatAppearance.BorderSize = 0;
            this.btnConfirmacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmacion.Location = new System.Drawing.Point(415, 224);
            this.btnConfirmacion.Name = "btnConfirmacion";
            this.btnConfirmacion.Size = new System.Drawing.Size(19, 19);
            this.btnConfirmacion.TabIndex = 8;
            this.btnConfirmacion.UseVisualStyleBackColor = false;
            this.btnConfirmacion.Click += new System.EventHandler(this.btnConfirmacion_Click);
            // 
            // btnConfirmacionN
            // 
            this.btnConfirmacionN.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmacionN.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.hide__1_;
            this.btnConfirmacionN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmacionN.FlatAppearance.BorderSize = 0;
            this.btnConfirmacionN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmacionN.Location = new System.Drawing.Point(415, 224);
            this.btnConfirmacionN.Name = "btnConfirmacionN";
            this.btnConfirmacionN.Size = new System.Drawing.Size(19, 19);
            this.btnConfirmacionN.TabIndex = 7;
            this.btnConfirmacionN.UseVisualStyleBackColor = false;
            this.btnConfirmacionN.Visible = false;
            this.btnConfirmacionN.Click += new System.EventHandler(this.btnConfirmacionN_Click);
            // 
            // frmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btnConfirmacion);
            this.Controls.Add(this.btnConfirmacionN);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnPasswordn);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNuevaContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0009 Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtConfirmacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnPasswordn;
        private System.Windows.Forms.Button btnConfirmacion;
        private System.Windows.Forms.Button btnConfirmacionN;
    }
}