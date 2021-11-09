using BitacoraUsuario;
using System;
using System.Windows.Forms;
using static datosUsuario;

namespace CapaVistaSeguridadHSC
{
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void btnActualizarBitacora_Click(object sender, EventArgs e)
        {
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0011", "Actualizar Bitácora");
            verBitacora.actualizarBitacora();
        }
    }
}