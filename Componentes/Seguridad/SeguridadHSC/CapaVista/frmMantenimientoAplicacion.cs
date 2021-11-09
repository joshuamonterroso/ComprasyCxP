using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using static datosUsuario;

//Forma Creada por Sebastián Moreira 9959-18-7960
namespace CapaVistaSeguridadHSC
{
    public partial class frmMantenimientoAplicacion : Form
    {
        Controlador conAplicacion = new Controlador();
        Bitacora loggear = new Bitacora();
        public frmMantenimientoAplicacion()
        {
            InitializeComponent();
            CenterToScreen();
            actualizardatagriew();
            llenarcbxAplicacion();

        }

        //Sebastián Moreira 9959-18-7960

        public void funLimpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            cbxModulo.SelectedIndex = 0;
        }


        //Sebastián Moreira 9959-18-7960
        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }





        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox4.Text = textBox4.Text.Replace("\\", "\\\\");
            textBox5.Text = textBox5.Text.Replace("\\", "\\\\");
        }
        //Sebastián Moreira 9959-18-7960
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Jorge González 0901-18-3920
                loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Inserción realizada");
                //
                conAplicacion.insertarAplicacion(textBox1.Text, textBox6.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, textBox5.Text);
                MessageBox.Show("Insercion realizada");
                funLimpiar();

            }
            catch (Exception ex)
            {
                //Jorge González 0901-18-3920
                loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Error al realizar Inserción");
                //
                MessageBox.Show("Error: Debes llenar todos los campos"+ex);
            }
            actualizardatagriew();
        }
        //Sebastián Moreira 9959-18-7960
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = textBox4.Text.Replace("\\", "\\\\");
                textBox5.Text = textBox5.Text.Replace("\\", "\\\\");
                //Jorge González 0901-18-3920
                loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Modificación Exitosa");
                //
                conAplicacion.modificarAplicacion(textBox1.Text, textBox6.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, textBox5.Text);
                Console.WriteLine(textBox1.Text + "    " + textBox6.Text + textBox2.Text + int.Parse(textBox3.Text) + textBox4.Text + textBox5.Text + "");
                MessageBox.Show("Modificacion realizada");
                funLimpiar();
                actualizardatagriew();
            }
            catch (Exception ex)
            {
                //Jorge González 0901-18-3920
                loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Error al modificar");
                //
                MessageBox.Show("Error: " + ex);
            }
        }
        //Sebastián Moreira 9959-18-7960
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Jorge González 0901-18-3920
                loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Eliminar");
                //
                conAplicacion.eliminarAplicacion(textBox1.Text);
                MessageBox.Show("Eliminacion realizada");
                funLimpiar();
                actualizardatagriew();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No has ingresado Id del registro a eliminar");
            }
        }
        //Sebastián Moreira 9959-18-7960
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }
        //Sebastián Moreira 9959-18-7960
        public void llenarcbxAplicacion()
        {
            try
            {
                cbxModulo.Items.Clear();
                OdbcDataReader datareader = conAplicacion.llenarcbxModulo();
                cbxModulo.Items.Add("Selecione un Modulo");
                while (datareader.Read())
                {
                    cbxModulo.Items.Add(datareader[0].ToString());
                }
                cbxModulo.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }




        //Sebastián Moreira 9959-18-7960
        private void button1_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    textBox4.Text = fd.SelectedPath.Replace("\\","\\\\");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //Sebastián Moreira 9959-18-7960
        private void button2_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    textBox5.Text = fd.SelectedPath.Replace("\\", "\\\\");
                }
            }
        }
        //Sebastián Moreira 9959-18-7960
        private void cbxModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {               
                    textBox6.Text = consultaModulo(cbxModulo.Text.ToString());                                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        String tabla = "Aplicacion";
        //Sebastián Moreira 9959-18-7960
        public void actualizardatagriew()
        {
            DataTable dt = conAplicacion.llenarTblAplicacion(tabla);
            dataGridView1.DataSource = dt;

        }
        //Sebastián Moreira 9959-18-7960
        public string consultaModulo(string nombre)
        {
            string id_modulo = conAplicacion.consultaModulo(nombre);

            return id_modulo;
        }
        //Sebastián Moreira 9959-18-7960
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString().Replace("\\", "\\\\");
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Replace("\\", "\\\\");

            if (textBox3.Text == "1")
            {
                btnHabilitado.Checked = true;
            }
            else if (textBox3.Text == "0")
            {
                btnInhabilitado.Checked = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }




}
