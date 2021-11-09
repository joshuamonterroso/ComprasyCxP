using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using CapaControladorReporte;
using System.Data.Odbc;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaReporte
{
    public partial class ReporteadorUsuario : Form
    {
        //Luis Reyes 0901-15-3121
        public ReporteadorUsuario()
        {
            InitializeComponent();
            actualizardatagriew();
        }
        Controlador sn = new Controlador();
        String tabla = "reporte"; // Aqui le asignamos a la variable tabla reportes que es el nombre de nuestra tabla
        //Luis Reyes 0901-15-3121
        public void actualizardatagriew() // Creamos una nueva funcion para llenar el datagriew con los datos de la BD reportes
        {
            DataTable dt = sn.llenarTbl(tabla);// iniciamos un objero DataTable que es la estructura del codigo de acceso a los datos de las tablas con la funcion llenarTb1
            dataGridView1.DataSource = dt; //esta linea de codigo el modelo que nos permite en enlase de datos de window forms 
        }
        //Luis Reyes 0901-15-3121
        public void busqueda() // Creamos una funcion para hacer la busqueda en la BD reportes
        {
            DataTable db = sn.llenarTb2(txtBusqueda.Text);// Iniciamos un objero DataTable = a la funicon llenarTb2 y le mandamos el dato que queremos que buscar que esta txtBusqueda
            dataGridView1.DataSource = db; // luego creamos el modelo DataSource que nos va a permitir crear un enlace de datos con widows forms 
        }
        //Luis Reyes 0901-15-3121
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }
        //Luis Reyes 0901-15-3121
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRuta.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); // cuando el usuario le da click en la fila del reporte que quiere ver se va la ruta del reporte al TxtReporte.Text 
            txtEstado.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        //Luis Reyes 0901-15-3121
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string est;
            est = Convert.ToString(txtEstado.Text);
            if (est == "A")
            {
                string r = txtRuta.Text;  // creamos una variable string r que seria = al dato que esta TxtReporte que es la ruta del reporte
                frmReporteEmp b = new frmReporteEmp(r);// Aqui creamos un nuevo objeto de Boton que le mandamos el dato que esta en la variable r
                b.Show(); // ahora llamamos al formulario para mostrar el reporte
            }
            else
            {
                MessageBox.Show("Reporte Desabilitado");
            }
        }
        //Luis Reyes 0901-15-3121
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
