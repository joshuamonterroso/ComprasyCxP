using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using System;
using System.Data;
using System.Windows.Forms;
using static datosUsuario;
//Forma Creada por Danny Saldaña 0901-18-18686
namespace CapaVistaSeguridadHSC
{
    public partial class frmAplicacionesPerfiles : Form
    {
        private Controlador cn = new Controlador();

        public frmAplicacionesPerfiles()
        {
            InitializeComponent();
            CenterToScreen();

            aplicacionllenarTbl();
            actualizardatagriew();
            actualizardatagriewpersonal();
        }

        //Mostrar los datos CAPA VISTA
        private string tabla = "usuario";

        private string tabla2 = "aplicacion"; //aplicacion
        private string tabla3 = "aplicacionperfil";

        //string tabla3 = "usuarioaplicacion"; //Usuario
        private string tabla4 = "perfil";
        //Danny Saldaña 0901-18-18686
        public void actualizardatagriew()
        {
            DataTable dt = cn.aplicacionllenarTbl(tabla2);
            dtgConsulta.DataSource = dt;
        }
        //Danny Saldaña 0901-18-18686
        public void aplicacionllenarTbl()
        {
            DataTable dt = cn.aplicacionllenarTblPerfil(tabla4);
            dataGridView2.DataSource = dt;
        }
        //Danny Saldaña 0901-18-18686
        public void actualizardatagriewpersonal()
        {
            DataTable dt = cn.aplicacionllenarTblPersonal(tabla2);
            dataGridView1.DataSource = dt;
        }
        //Danny Saldaña 0901-18-18686
        private void button1_Click(object sender, EventArgs e)
        {
            aplicacionllenarTbl();
            actualizardatagriew();
            actualizardatagriewpersonal();
        }
        //Danny Saldaña 0901-18-18686
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
        //Danny Saldaña 0901-18-18686
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox3.Text = dtgConsulta.CurrentRow.Cells[0].Value.ToString();

                textBox3.Text = dtgConsulta.CurrentRow.Cells[0].Value.ToString();
                textBox4.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

                string valor1 = textBox4.Text;
                string valor2 = textBox3.Text;
                cn.aplicacionagregar(tabla3, valor1, valor2);
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Asignar");
                //
                actualizardatagriewpersonal();
                actualizardatagriewpersonal();
            }
            catch
            {
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        //Danny Saldaña 0901-18-18686
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                string valor1 = textBox4.Text;
                string valor2 = textBox3.Text;
                cn.aplicacioneliminar(tabla3, valor1, valor2);
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Quitar");
                //
                actualizardatagriewpersonal();
                actualizardatagriewpersonal();
            }
            catch
            {
            }
        }
        //Danny Saldaña 0901-18-18686
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        //Danny Saldaña 0901-18-18686
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Quitar todo");
                //
                cn.aplicacioneliminartodo(tabla3);
                actualizardatagriewpersonal();
            }
            catch
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string valor1 = textBox1.Text;
            //string valor2 = textBox3.Text;
            //string condicion = textBox1.Text;
            //cn.aplicacioneliminartodo(tabla3, valor1);
            //cn.aplicacionagregartodo(tabla3, valor1, valor2, tabla2);
        }
        //Danny Saldaña 0901-18-18686
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Llenar con Enter

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                actualizardatagriewpersonal();
                actualizardatagriew();
                aplicacionllenarTbl();
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button6_Click(object sender, EventArgs e)
        {
            //Jorge González 0901-18-3920
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0005", "Limpiar");
            //
            textBox3.Text = "";
            dtgConsulta.DataSource = null;
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
        }

        //Utilizar flechas para moverse entre botones
        //Danny Saldaña 0901-18-18686
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button3.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button4.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button2.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button5.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button6.Focus();//Mueve al siguiente boton
            }
        }
        //Danny Saldaña 0901-18-18686
        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
            }
        }
        //Danny Saldaña 0901-18-18686
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
            }
        }
    }
}