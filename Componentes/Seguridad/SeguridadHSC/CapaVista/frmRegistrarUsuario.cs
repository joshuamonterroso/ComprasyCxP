using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using System;
using System.Windows.Forms;
using static datosUsuario;
//Forma Creada por Jorge González 0901-18-3920
namespace CapaVistaSeguridadHSC
{
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
            CenterToScreen();
        }
        //Jorge González 0901-18-3920
        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Controlador s = new Controlador();
            Encriptar a = new Encriptar();
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0002", "Registrar");
            string hash = a.funcEncryptString(key, txtContraseña.Text);
            s.registrarUsuario(txtIdUsuario.Text, txtIdEmpleado.Text, txtUsuario.Text, hash, "1");
        }
    }
}