using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorCompras;
using System.Data.Odbc;

namespace CapaVistaCompras
{
    public partial class frmTrasladoProducto : Form
    {
        clscontrolador logi = new clscontrolador();
        public frmTrasladoProducto()
        {
            InitializeComponent();
        }

        //Andrea Guerra 0901-18-858
        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = logi.consultar("trasladoproducto"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }



        private void frmTrasladoProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            mostrar_consulta();
            Llenarbodega();
            Llenarproducto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text }; //valores a ingresar
            if (logi.insertar_traslado(valores) == null)
            {
                MessageBox.Show("Error al guardar");
            }

            else
            {
                MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";


                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox5.Text = "";
                comboBox6.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            mostrar_consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";


            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
        }


        public void Llenarbodega()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();

            OdbcDataReader cbodegas = logi.llenarbodega();

            while (cbodegas.Read())
            {
                comboBox1.Items.Add(cbodegas[1]);
                comboBox2.Items.Add(cbodegas[1]);
                comboBox4.Items.Add(cbodegas[0]);
                comboBox5.Items.Add(cbodegas[0]);
            }
        }

        //producto
        public void Llenarproducto()
        {
            comboBox3.Items.Clear();
            comboBox6.Items.Clear();

            OdbcDataReader cproducto = logi.llenarproducto();

            while (cproducto.Read())
            {
                comboBox3.Items.Add(cproducto[1]);
                comboBox6.Items.Add(cproducto[0]);
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = comboBox1.SelectedIndex;
            textBox2.Text = comboBox4.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox5.SelectedIndex = comboBox2.SelectedIndex;
            textBox3.Text = comboBox5.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.SelectedIndex = comboBox3.SelectedIndex;
            textBox6.Text = comboBox6.SelectedItem.ToString();
        }
    }
}
