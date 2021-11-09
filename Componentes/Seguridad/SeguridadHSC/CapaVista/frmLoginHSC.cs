using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using System;
using System.Windows.Forms;
using static datosUsuario;
//Forma Creada por Kevin Flores 9959-18-17632
namespace CapaVistaSeguridadHSC
{
    public partial class frmLoginHSC : Form
    {

        private Controlador conAplicacion = new Controlador();


        public frmLoginHSC()
        {
            InitializeComponent();

            txtUsuario.Focus();
            CenterToScreen();
        }

        private string nombreUsuario = "";
        //Kevin Flores 9959-18-17632
        public string obtenerNombreUsuario()
        {
            nombreUsuario = txtUsuario.Text;
            return nombreUsuario;
        }

        private void frmLoginHSC_Load(object sender, EventArgs e)
        {
        }
        //Kevin Flores 9959-18-17632
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            funValidarClave();
        }
        //Kevin Flores 9959-18-17632
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            funValidarUsuario();
        }
        //Kevin Flores 9959-18-17632
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text.Trim();
            string Contraseña = txtClave.Text.Trim();
            int contador = 0;
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            if (contador <= 3)
            {
                Encriptar encriptar = new Encriptar();
                string password = encriptar.funcEncryptString(key, txtClave.Text);
                Console.WriteLine(password);
                if (conAplicacion.funIniciarSesion(txtUsuario.Text, password) == 1)
                {
                    //Jorge González 0901-18-3920
                    // Bitácora
                    Bitacora loggear = new Bitacora();
                    IdUsuario = loggear.obtenerIdDeUsuario(Usuario);
                    loggear.guardarEnBitacora(IdUsuario, "1", "0001", "Inicio de sesión exitoso");
                    DialogResult = DialogResult.OK;
                    // Fin bitácora

                    MessageBox.Show(" Bienvenido " + txtUsuario.Text);
                  /*  funLimpiar();
                    this.Hide();
                    var form2 = new frmMIDSeguridad();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();*/
                }
                else
                {
                    contador++;
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    funLimpiar();
                }
            }
            if (contador > 3)
            {
                conAplicacion.funcBloquearUsuario(txtUsuario.Text);
                MessageBox.Show("El usuario a sido Bloqueado por seguridad.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                funLimpiar();
            }

            /*
            int validar = 0;
            string Usuario = txtUsuario.Text.Trim();
            string Contraseña = txtClave.Text.Trim();
            validar = conAplicacion.InicarSesion(Usuario, Contraseña, validar);

            if (txtUsuario.Text != "")
            {
                if (validar != 0)
                {
                    MessageBox.Show("Error 305: " + "Usuario o contraseña incorrectos. ");
                    funLimpiar();
                }
                else
                {
                    //llamada a la forma
                    BitacoraLoginUsuario loggear = new BitacoraLoginUsuario();
                    string id = loggear.obtenerIdDeUsuario(Usuario);
                    loggear.guardarLoginUsuario(id, "1");
                    MessageBox.Show(" Bienvenido " + Usuario);
                    funLimpiar();
                    this.Hide();
                    var form2 = new frmMIDSeguridad();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar su usuario ");
            }*/
        }
        //Kevin Flores 9959-18-17632
        public string usuario()
        {
            return txtUsuario.Text;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        //Kevin Flores 9959-18-17632
        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = false;
            btnPassword.Visible = false;
            btnPasswordn.Visible = true;
        }
        //Kevin Flores 9959-18-17632
        private void btnPasswordn_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
            btnPassword.Visible = true;
            btnPasswordn.Visible = false;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //mostrara ayuda
            //Help.ShowHelp(this, "mostrara ayuda");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        //Kevin Flores 9959-18-17632
        public void funLimpiar()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            lblClave.Text = "";
            lblUsuario.Text = "";
            adClave.Visible = false;
            adUser.Visible = false;
        }
        //Kevin Flores 9959-18-17632
        public void funValidarUsuario()
        {
            if (txtUsuario.Text.Trim() != "")
            {
                lblUsuario.Text = "";
                adUser.Visible = false;
            }
            else
            {
                lblUsuario.Text = "Debe ingresar usuario.";
                adUser.Visible = true;
            }
        }
        //Kevin Flores 9959-18-17632
        public void funValidarClave()
        {
            if (txtClave.Text.Trim() != "")
            {
                lblClave.Text = "";
                adClave.Visible = false;
            }
            else
            {
                lblClave.Text = "Debe ingresar contraseña.";
                adClave.Visible = true;
            }
        }
        //Kevin Flores 9959-18-17632
        private void txtUsuario_EnabledChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }
        //Kevin Flores 9959-18-17632
        //Desplasamiento con botones
        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                funValidarClave();
                btnIniciarSesion.Focus();//llama al evento click del boton
            }
        }
        //Kevin Flores 9959-18-17632
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                txtClave.Focus();
                funValidarUsuario();
            }
        }
        //Kevin Flores 9959-18-17632
        private void lkbRecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            funLimpiar();
            this.Hide();
            var form2 = new frmRecuperarContraseña();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}