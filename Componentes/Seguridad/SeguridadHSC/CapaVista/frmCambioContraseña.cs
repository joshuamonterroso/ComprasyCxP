using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using System;
using System.Windows.Forms;
using static datosUsuario;

//Forma Creada por Roberto Lopez 0901-18-4982

namespace CapaVistaSeguridadHSC
{
    public partial class frmCambioContraseña : Form
    {
        private string Usuario = "";

        public frmCambioContraseña()
        {
            InitializeComponent();
            CenterToScreen();
        }
        //Roberto Lopez 0901-18-4982
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            Encriptar encriptar = new Encriptar();
            Controlador controladorPerfil = new Controlador();
            if (txtNuevaContraseña.Text == "" || txtConfirmarContraseña.Text == "")
            {
                MessageBox.Show("Los Campos no Deben de Estar Vacios");
            }
            else
            {
                if (txtNuevaContraseña.Text == txtConfirmarContraseña.Text)
                {
                    string password = encriptar.funcEncryptString(key, txtConfirmarContraseña.Text);
                    controladorPerfil.funcModificar_Contraseña(Usuario, password);
                    MessageBox.Show("Contraseña Actualizada");
                    txtNuevaContraseña.Text = "";
                    txtConfirmarContraseña.Text = "";
                    //Jorge González 0901-18-3920
                    // Prueba bitácora
                    Bitacora loggear = new Bitacora();
                    loggear.guardarEnBitacora(IdUsuario, "1", "0010", "Confirmar cambio");
                    // Fin bitácora

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseñas No Coinciden");
                    txtNuevaContraseña.Text = "";
                    txtConfirmarContraseña.Text = "";
                }
            }
        }
    }
}