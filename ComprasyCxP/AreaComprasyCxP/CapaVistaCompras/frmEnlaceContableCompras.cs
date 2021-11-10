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

namespace CapaVistaCompras
{
    public partial class frmEnlaceContableCompras : Form
    {
        clscontrolador con = new clscontrolador();

        string totalSaldoDebe;
        string totalSaldoHaber;
        //   string idTotal;
        string fechaHoy;
        public frmEnlaceContableCompras()
        {
            InitializeComponent();
            textBox1.Text = incrementarId();
        }

        private void frmEnlaceContableCompras_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaI = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string fechaF = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                fechaHoy = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                totalSaldoDebe = calculoDebe(fechaI, fechaF);
                totalSaldoHaber = calculoHaber(fechaI, fechaF);
                insertar();
                //Llenando encabezado
                MessageBox.Show("¨Poliza de totales guardada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {

            }


        }

        public string calculoDebe(string fechaInicio, string fechaFinal)
        {
            totalSaldoDebe = con.calculoDebe(fechaInicio, fechaFinal);
            return totalSaldoDebe;
        }

        public string calculoHaber(string fechaInicio, string fechaFinal)
        {
            totalSaldoHaber = con.calculoHaber(fechaInicio, fechaFinal);
            return totalSaldoHaber;
        }


        //Sumarle 1 al ultimo id
        public string incrementarId()
        {
            string id;
            id = con.incrementarId();

            int aux = int.Parse(id);
            aux++;

            id = aux.ToString();


            return id;
        }

        public string insertarEncabezado()
        {
            string id = "";
            //string idEncabezado = incrementarId();
            fechaHoy = dateTimePicker3.Value.ToString("yyyy-MM-dd");

            con.insertarEncabezado(textBox1.Text, fechaHoy, "1");
            id = buscarId();

            return id;
        }

        public string buscarId()
        {
            string id = "";

            id = con.incrementarId();

            return id;
        }
        public void insertarDetalleDebe(string id)
        {
            fechaHoy = dateTimePicker3.Value.ToString("yyyy-MM-dd");


            string fechaI = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fechaF = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            totalSaldoDebe = calculoDebe(fechaI, fechaF);


            con.insertarDetalle(textBox1.Text, fechaHoy, "1", totalSaldoDebe, "1", textBox2.Text);

        }


        public void insertarDetalleHaber(string id)
        {
            fechaHoy = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            string fechaI = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fechaF = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            totalSaldoHaber = calculoHaber(fechaI, fechaF);

            con.insertarDetalle(textBox1.Text, fechaHoy, "2", totalSaldoHaber, "2", textBox2.Text);

        }


        public void insertar()
        {

            string id = insertarEncabezado();
            insertarDetalleDebe(id);

            insertarDetalleHaber(id);

        }
    }
}