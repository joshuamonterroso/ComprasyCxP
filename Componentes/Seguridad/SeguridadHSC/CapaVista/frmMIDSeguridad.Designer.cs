
namespace CapaVistaSeguridadHSC
{
    partial class frmMIDSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMIDSeguridad));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignacionDeAplicacionAUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignacionDeAplicacionesAPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsiginaciónDePerfilesAUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCambioContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.módulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mantenimientosToolStripMenuItem,
            this.asignacionesToolStripMenuItem1,
            this.btnCambioContraseña,
            this.btnBitacora});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.btnCerrarSesion});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(175, 24);
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnAplicacion,
            this.módulosToolStripMenuItem,
            this.btnPerfiles});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem});
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(180, 24);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // btnAplicacion
            // 
            this.btnAplicacion.Name = "btnAplicacion";
            this.btnAplicacion.Size = new System.Drawing.Size(180, 24);
            this.btnAplicacion.Text = "Aplicaciones";
            this.btnAplicacion.Click += new System.EventHandler(this.btnAplicacion_Click);
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Size = new System.Drawing.Size(180, 24);
            this.btnPerfiles.Text = "Perfiles";
            this.btnPerfiles.Click += new System.EventHandler(this.btnPerfiles_Click);
            // 
            // asignacionesToolStripMenuItem1
            // 
            this.asignacionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAsignacionDeAplicacionAUsuarios,
            this.btnAsignacionDeAplicacionesAPerfiles,
            this.btnAsiginaciónDePerfilesAUsuarios,
            this.btnPermisos});
            this.asignacionesToolStripMenuItem1.Name = "asignacionesToolStripMenuItem1";
            this.asignacionesToolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.asignacionesToolStripMenuItem1.Text = "Asignaciones";
            // 
            // btnAsignacionDeAplicacionAUsuarios
            // 
            this.btnAsignacionDeAplicacionAUsuarios.Name = "btnAsignacionDeAplicacionAUsuarios";
            this.btnAsignacionDeAplicacionAUsuarios.Size = new System.Drawing.Size(340, 24);
            this.btnAsignacionDeAplicacionAUsuarios.Text = "Asignacion de Aplicacion a Usuarios";
            this.btnAsignacionDeAplicacionAUsuarios.Click += new System.EventHandler(this.btnAsignacionDeAplicacionAUsuarios_Click);
            // 
            // btnAsignacionDeAplicacionesAPerfiles
            // 
            this.btnAsignacionDeAplicacionesAPerfiles.Name = "btnAsignacionDeAplicacionesAPerfiles";
            this.btnAsignacionDeAplicacionesAPerfiles.Size = new System.Drawing.Size(340, 24);
            this.btnAsignacionDeAplicacionesAPerfiles.Text = "Asignacion de Aplicaciones a Perfiles";
            this.btnAsignacionDeAplicacionesAPerfiles.Click += new System.EventHandler(this.btnAsignacionDeAplicacionesAPerfiles_Click);
            // 
            // btnAsiginaciónDePerfilesAUsuarios
            // 
            this.btnAsiginaciónDePerfilesAUsuarios.Name = "btnAsiginaciónDePerfilesAUsuarios";
            this.btnAsiginaciónDePerfilesAUsuarios.Size = new System.Drawing.Size(340, 24);
            this.btnAsiginaciónDePerfilesAUsuarios.Text = "Asiginación de Perfiles a Usuarios";
            this.btnAsiginaciónDePerfilesAUsuarios.Click += new System.EventHandler(this.btnAsiginaciónDePerfilesAUsuarios_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(340, 24);
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnCambioContraseña
            // 
            this.btnCambioContraseña.Name = "btnCambioContraseña";
            this.btnCambioContraseña.Size = new System.Drawing.Size(162, 24);
            this.btnCambioContraseña.Text = "Cambio Contraseña";
            this.btnCambioContraseña.Click += new System.EventHandler(this.btnCambioContraseña_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitácoraDeLoginToolStripMenuItem});
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(80, 24);
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // bitácoraDeLoginToolStripMenuItem
            // 
            this.bitácoraDeLoginToolStripMenuItem.Name = "bitácoraDeLoginToolStripMenuItem";
            this.bitácoraDeLoginToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.bitácoraDeLoginToolStripMenuItem.Text = "Bitácora de Login";
            this.bitácoraDeLoginToolStripMenuItem.Click += new System.EventHandler(this.bitácoraDeLoginToolStripMenuItem_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(688, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.Visible = false;
            // 
            // módulosToolStripMenuItem
            // 
            this.módulosToolStripMenuItem.Name = "módulosToolStripMenuItem";
            this.módulosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.módulosToolStripMenuItem.Text = "Módulos";
            this.módulosToolStripMenuItem.Click += new System.EventHandler(this.módulosToolStripMenuItem_Click);
            // 
            // frmMIDSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMIDSeguridad";
            this.Text = "Seguridad HSC";
            this.Load += new System.EventHandler(this.frmLoginHSC_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnAplicacion;
        private System.Windows.Forms.ToolStripMenuItem btnPerfiles;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnAsignacionDeAplicacionAUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnAsignacionDeAplicacionesAPerfiles;
        private System.Windows.Forms.ToolStripMenuItem btnCambioContraseña;
        private System.Windows.Forms.ToolStripMenuItem btnBitacora;
        private System.Windows.Forms.ToolStripMenuItem btnAsiginaciónDePerfilesAUsuarios;
        private System.Windows.Forms.ToolStripMenuItem bitácoraDeLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPermisos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módulosToolStripMenuItem;
    }
}