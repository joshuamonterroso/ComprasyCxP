using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using System;
using System.Data.Odbc;
using System.Windows.Forms;
using static datosUsuario;
//Forma Creada por Kevin Flores 9959-18-17632
namespace CapaVistaSeguridadHSC
{
    public partial class frmRecuperarContraseña : Form
    {
        private Controlador conAplicacion = new Controlador();

        //string Usuario = "";
        public frmRecuperarContraseña()
        {
            InitializeComponent();
            llenarcbxUsuario();
            CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        //Kevin Flores 9959-18-17632
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                Encriptar encriptar = new Encriptar();
                Controlador controladorPerfil = new Controlador();
                if (txtConfirmacion.Text != null && txtContraseña.Text != null && cbxUsuario.SelectedIndex != -1 || cbxUsuario.SelectedIndex != 0)
                {
                    if (txtContraseña.Text != txtConfirmacion.Text)
                    {
                        MessageBox.Show("La contraseña no es igual.");
                        //Jorge González 0901-18-3920
                        Bitacora loggear = new Bitacora();
                        loggear.guardarEnBitacora(IdUsuario, "1", "0009", "Fallo al Recuperar Contraseña");
                        //
                        funLimpiar();
                    }
                    else
                    {
                        //conAplicacion.recuperarContraseña( cbxUsuario.SelectedIndex.ToString(),txtConfirmacion.Text.Trim());
                        string password = encriptar.funcEncryptString(key, txtConfirmacion.Text.Trim());
                        conAplicacion.recuperarContraseña(cbxUsuario.SelectedIndex.ToString(), password);

                        MessageBox.Show("Modificación Realizada");
                        //Jorge González 0901-18-3920
                        Bitacora loggear = new Bitacora();
                        loggear.guardarEnBitacora(IdUsuario, "1", "0009", "Recuperar contraseña");
                        //
                        funLimpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Una o más casillas vacías.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        //Kevin Flores 9959-18-17632
        public void llenarcbxUsuario()
        {
            try
            {
                cbxUsuario.Items.Clear();
                OdbcDataReader datareader = conAplicacion.llenarcbo();
                cbxUsuario.Items.Add("Selecione un Usuario");
                while (datareader.Read())
                {
                    cbxUsuario.Items.Add(datareader[0].ToString());
                }
                cbxUsuario.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
        //Kevin Flores 9959-18-17632
        public void funLimpiar()
        {
            txtContraseña.Text = "";
            txtConfirmacion.Text = "";

            cbxUsuario.SelectedIndex = 0;
        }
        //Kevin Flores 9959-18-17632
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Jorge González 0901-18-3920
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0009", "Limpiar");
            //
            funLimpiar();
        }
        //Kevin Flores 9959-18-17632
        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            btnPassword.Visible = false;
            btnPasswordn.Visible = true;
        }
        //Kevin Flores 9959-18-17632
        private void btnPasswordN_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            btnPassword.Visible = true;
            btnPasswordn.Visible = false;
        }
        //Kevin Flores 9959-18-17632
        private void btnConfirmacion_Click(object sender, EventArgs e)
        {
            txtConfirmacion.UseSystemPasswordChar = false;
            btnConfirmacion.Visible = false;
            btnConfirmacionN.Visible = true;
        }

        private void btnConfirmacionN_Click(object sender, EventArgs e)
        {
            txtConfirmacion.UseSystemPasswordChar = true;
            btnConfirmacion.Visible = true;
            btnConfirmacionN.Visible = false;
        }
    }
}