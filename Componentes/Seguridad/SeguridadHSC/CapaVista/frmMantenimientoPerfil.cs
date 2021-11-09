using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using System;
using System.Data;
using System.Windows.Forms;
using static datosUsuario;
//Forma Creada por Ivania Gatica 0901-18-19528
namespace CapaVistaSeguridadHSC
{
    //0901-18-17144 Luis De la Cruz
    public partial class frmMantenimientoPerfil : Form
    {
        private bloqueos b = new bloqueos();
        private string idaplicacion = "1";
        string usuario = "1";
        string permisos;


        private Controlador cn = new Controlador();

        public frmMantenimientoPerfil()
        {
            InitializeComponent();
            CenterToScreen();
            actualizardatagriew();
            permisos = bloqueo(usuario, idaplicacion);
        }

        private string tabla = "perfil";

        //0901-18-19528 Ivania Gatica -- 0901-18-17144 Luis De la Cruz 

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(tabla);
            perfilTabla.DataSource = dt;
        }

        public void funLimpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;
            textBox3.Text = "";
        }

        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void frmMantenimientoPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSet3.perfil' Puede moverla o quitarla según sea necesario.
            }
            catch (Exception Error)
            {
                Console.WriteLine("404", Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void perfilTabla_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //Ivania Gatica 0901-18-19528
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0012", "Insertar");
                //
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
                {
                    //Jorge González 0901-18-3920
                    loggear.guardarEnBitacora(IdUsuario, "1", "0004", "Inserción realizada");
                    //
                    cn.insertarPerfil(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
                    MessageBox.Show("Insercion realizada");
                    funLimpiar();
                }
                else
                {
                    loggear.guardarEnBitacora(IdUsuario, "1", "0004", "Error al realizar Inserción");
                    MessageBox.Show("Error debe de ingresar todos los valores solicitados ");
                }
            }
            catch
            {
                MessageBox.Show("Error debe de ingresar todos los valores solicitados ");
            }
            actualizardatagriew();
        }
        //Luis de la Cruz 0901-18-17144
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0004", "Modificación Exitosa");
                //
                cn.modificarPerfil(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
                MessageBox.Show("Insercion realizada");
                funLimpiar();
            }
            else
            {
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0004", "Error al modificar");
                //
                MessageBox.Show("Error debe de ingresar todos los valores solicitados ");
            }
            actualizardatagriew();
        }
        //Ivania Gatica 0901-18-19528
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Jorge González 0901-18-3920
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0004", "Eliminar");
            //
            cn.eliminarPerfil(textBox1.Text);
            MessageBox.Show("Eliminacion realizada");
            funLimpiar();
            actualizardatagriew();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }
        
        public void actualizarTablaDeporte()
        {
            try
            {
                //CapaVista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
            }
            catch (Exception Error)
            {
                Console.WriteLine("404 ", Error);
            }
        }
        //Ivania Gatica 0901-18-19528
        private void perfilTabla_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox1.Text = perfilTabla.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = perfilTabla.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = perfilTabla.CurrentRow.Cells[2].Value.ToString();

                if (textBox3.Text == "1")
                {
                    btnHabilitado.Checked = true;
                }
                else if (textBox3.Text == "0")
                {
                    btnInhabilitado.Checked = true;
                }
            }
            catch
            {
            }
        }
        //Luis de la Cruz 0901-18-17144
        public string bloqueo(string id, string app)
        {
            string cadena = b.bloqueo(id, app);


            return cadena;
        }
    }
}