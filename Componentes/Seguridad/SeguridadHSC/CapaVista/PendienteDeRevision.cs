using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using static datosUsuario;

//0901-18-4982  Roberto Lopez
namespace CapaVistaSeguridadHSC
{
    public partial class PendienteDeRevision : Form
    {
        private Controlador cn = new Controlador();

        public PendienteDeRevision()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //Mostrar los datos CAPA VISTA
        private string tabla = "perfil";

        private string tabla2 = "aplicacion";
        private string tabla3 = "aplicacionperfil";

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTblappaperf(tabla2);
            dtgConsulta.DataSource = dt;
        }

        public void actualizardatagriewpersonal()
        {
            string condicion = textBox1.Text;
            DataTable dt = cn.llenarTblPersonalappaperf(tabla2, condicion);
            dataGridView1.DataSource = dt;
        }

        public void llenarnombre()
        {
            string condicion = textBox1.Text;
            DataTable dt = cn.llenarNombreappaperf(tabla, condicion);
            string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            textBox2.Text = dta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Consulta");
            string condicion = textBox1.Text;
            actualizardatagriew();
            llenarnombre();
            actualizardatagriewpersonal();
        }

        private void dtgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dtgConsulta.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void fmConsulta_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = dtgConsulta.CurrentRow.Cells[0].Value.ToString();
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Asignar");
            string valor1 = textBox1.Text;
            string valor2 = textBox3.Text;
            cn.agregarappaperf(tabla3, valor1, valor2);
            actualizardatagriewpersonal();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Quitar");
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string valor1 = textBox1.Text;
            string valor2 = textBox3.Text;
            cn.eliminarappaperf(tabla3, valor1, valor2);
            actualizardatagriewpersonal();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Quitar todo");
            string valor1 = textBox1.Text;
            cn.perfileliminartodoappaperf(tabla3, valor1);
            actualizardatagriewpersonal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            string valor2 = textBox3.Text;
            string condicion = textBox1.Text;
            cn.perfileliminartodoappaperf(tabla3, valor1);
            cn.perfilagregartodoappaperf(tabla3, valor1, valor2, tabla2);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Llenar con Enter

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                llenarnombre();//llama al evento click del boton
                actualizardatagriewpersonal();
                actualizardatagriew();
                textBox2.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Limpiar");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dtgConsulta.DataSource = null;
            dataGridView1.DataSource = null;
        }

        //Utilizar flechas para moverse entre botones

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button3.Focus();//Mueve al siguiente boton
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button4.Focus();//Mueve al siguiente boton
            }
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button2.Focus();//Mueve al siguiente boton
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button5.Focus();//Mueve al siguiente boton
            }
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button6.Focus();//Mueve al siguiente boton
            }
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button1.Focus();//Mueve al siguiente boton
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                textBox1.Focus();//Mueve al siguiente boton
            }
        }
    }
}