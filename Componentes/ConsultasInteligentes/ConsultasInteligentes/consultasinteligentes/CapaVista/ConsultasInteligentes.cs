using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using System.Data.Odbc;


namespace CapaVista
{
    public partial class ConsultasInteligentes : Form
    {
        string campo = "";
        string csimple = "";
        string where = "";
        string and = "";
        string group = "";
        string final = "";
        string orden = "";
        public ConsultasInteligentes()
        {
            InitializeComponent();
        }

        private void btnCancelarCamposSeleccionados_Click(object sender, EventArgs e)
        {
        campo ="";
        csimple = "";
            txtcamposelectos.Text = "";
            txtCadenaGenerada.Text = "";


        }
        clscontrolador cn = new clscontrolador();

        private void ConsultasInteligentes_Load(object sender, EventArgs e)
        {
            llenarcombo();
            llenarcboquery();
            llenarcomboeditar();
            tablaseditar();
        }

        string consulta = "";
        //Adolfo Monterroso 0901-18-50
        //El dataGrid se llena con las consultas existentes
        public void actualizardatagrid()
        {
            DataTable dt = cn.llenartb1(consulta);
            dgvCONSULTAS.DataSource = dt;
        }
        //Adolfo Monterroso 0901-18-50
        //Llenar combobox de tablas
        public void llenarcombo()
        {
            cbotablas.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo();
            while (datareader.Read())
            {
                cbotablas.Items.Add(datareader[0].ToString());
            }
        }

        //Adolfo Monterroso 0901-18-50
        //Llenar combobox con consultas almacenadas
        public void llenarcboinsert(string prueba)
        {
                cbovalidar.Items.Clear();
                OdbcDataReader dataReader = cn.llenarinsert(prueba);
                    while (dataReader.Read())
                    {
                        cbovalidar.Items.Add(dataReader[0].ToString());
                    }
        }
        //Adolfo Monterroso 0901-18-50
        //Llenar combos de columnas de tablas
        public void llenarcombo2()
        {
            cboCampos.Items.Clear();
            cboCampoLogica.Items.Clear();
            cboCampoComparacion.Items.Clear();
            cboCampoAgruparOrdenar.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo2(valortabla.Text);
            while (datareader.Read())
            {
                cboCampos.Items.Add(datareader[0].ToString());
                cboCampoLogica.Items.Add(datareader[0].ToString());
                cboCampoComparacion.Items.Add(datareader[0].ToString());
                cboCampoAgruparOrdenar.Items.Add(datareader[0].ToString());
            }
        }

        string query = "registro_consultas";
        //Adolfo Monterroso 0901-18-50
        //Llenamos los combobox con querys existentes
        public void llenarcboquery()
        {
            cboQuery.Items.Clear();
            cbocopiaquery.Items.Clear();
            OdbcDataReader datareader = cn.llenarcboq(query);
            while (datareader.Read())
            {
                cboQuery.Items.Add(datareader[0].ToString());
                cbocopiaquery.Items.Add(datareader[1].ToString());
            }
        }
        private void cboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        //Adolfo Monterroso 0901-18-50
        //Agregamos consultas
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (chkSelectTodos.Checked == false)
            {            
                if (txtcamposelectos.Text.Equals(""))
                {
                    if (txtAlias.Text.Equals(""))
                    {
                        txtcamposelectos.Text = "";
                        campo = campo + cboCampos.SelectedItem.ToString() + " ";
                        txtcamposelectos.Text = campo;
                    } else
                    {
                        txtcamposelectos.Text = "";
                        campo = campo + cboCampos.SelectedItem.ToString() + " as "+ txtAlias.Text +" ";
                        txtcamposelectos.Text = campo;
                    }
                }
                else{
                    if (txtAlias.Text.Equals(""))
                    {
                        txtcamposelectos.Text = "";
                        campo =  campo +", " + cboCampos.SelectedItem.ToString() + " ";
                        txtcamposelectos.Text = campo;
                    }
                    else
                    {
                        txtcamposelectos.Text = "";
                        campo =  campo + ", " + cboCampos.SelectedItem.ToString() + " as " + txtAlias.Text + " ";
                        txtcamposelectos.Text = campo;
                    }
                }
            } else
            {
                txtcamposelectos.Text = "";
                campo = "";
                campo = " * ";
                txtcamposelectos.Text = "Todos los campos seleccionados";
                Console.WriteLine(campo);
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void chkSelectTodos_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkSelectTodos.Checked == true)
            {
                txtAlias.Text = "";
                txtAlias.Enabled = false;
                cboCampos.Text = "";
                cboCampos.Enabled = false;
                txtcamposelectos.Text = "";
            } else
            {
                txtAlias.Text = "";
                txtAlias.Enabled = true;
                cboCampos.Text = "";
                cboCampos.Enabled = true;
            }            
        }
        private void btprueba_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //Adolfo Monterroso 0901-18-50
        private void chkcondiciones_CheckedChanged(object sender, EventArgs e)
        {
            if ((chkcondiciones.Checked == true) && (csimple !=""))
            {
                gpbConsultaCompleja.Enabled = true;
                gpbAgruparUOrdenar.Enabled  = true;
            } else
            {
                gpbConsultaCompleja.Enabled =  false;
                gpbAgruparUOrdenar.Enabled  =  false;                
                chkcondiciones.Checked = false;
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void btnAgregarCamposSeleccionados_Click(object sender, EventArgs e)
        {
            if (campo == "")
            {
                MessageBox.Show("Debe seleccionar al menos un campo");
            } else
            {            
            csimple = "SELECT " + campo + "FROM " + valortabla.Text + " " ;
            Console.WriteLine(csimple);
            txtCadenaGenerada.Text = csimple;
            campo = "";
            txtAlias.Text = "";
            cboCampos.Text = "";         
            txtcamposelectos.Text = "";
            cboTabla.Text = "";
            chkSelectTodos.Checked = false;
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void button10_Click(object sender, EventArgs e)
        {
            //Boton de crear
            final = csimple + " " + where + " " + and + " " + group + ";";
            if (csimple =="")
            {
                MessageBox.Show("Consulta incorrecta");
                limpiar();
                habilitaciones();
                txtNombreConsulta.Focus();
            }
            else
            {
            MessageBox.Show("Consulta Almacenada");
            cn.ingresarconsulta(txtNombreConsulta.Text, final);
            llenarcboquery();
            limpiar();
            habilitaciones();
            txtNombreConsulta.Focus();
            cbotablas.Text = "";
            }
        }

        //Adolfo Monterroso 0901-18-50
        public void limpiar()
        {
            chkcondiciones.Checked = false;
            txtCadenaGenerada.Text = "";
            txtcamposelectos.Text = "";
            txtAlias.Text = "";
            txtNombreConsulta.Text = "";
            valortabla.Text = "";
            txtValor.Text = "";
            txtValorComparacion.Text = "";
            cboAgruparOrdenar.Text = "";
            cboCampos.Text = "";
            cboTabla.Text = "";
            cboOperadorLogico.Text = "";
            cboCampoLogica.Text = "";
            cboTipoComparador.Text = "";
            cboCampoComparacion.Text = "";
            cboCampoAgruparOrdenar.Text = "";
            campo = "";
            csimple = "";
            where = "";
            and = "";
            group = "";
            final = "";
        }

        //Adolfo Monterroso 0901-18-50
        public void habilitaciones()
        {
            gpbConsultaCompleja.Enabled = false;
            gpbAgruparUOrdenar.Enabled  = false;
            chkcondiciones.Checked      = false;
            chkSelectTodos.Checked      = false;

        }

        //Adolfo Monterroso 0901-18-50
        private void button11_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitaciones();
            cbotablas.Text = "";
        }

        //Adolfo Monterroso 0901-18-50
        private void btnBuscarCONSULTAS_Click(object sender, EventArgs e)
        {
            actualizardatagrid();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //Adolfo Monterroso 0901-18-50
        private void cboQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocopiaquery.SelectedIndex = cboQuery.SelectedIndex;
            txtCadenaGeneradaCONSULTAS.Text = cbocopiaquery.SelectedItem.ToString();
            consulta = txtCadenaGeneradaCONSULTAS.Text;
        }

        private void cbocopiaquery_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboCampos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Adolfo Monterroso 0901-18-50
        private void btnAgregarComparacion_Click(object sender, EventArgs e)
        {
                where = cboTipoComparador.SelectedItem.ToString() + " " + cboCampoComparacion.SelectedItem.ToString() + "=" +
                '"' + txtValorComparacion.Text + '"' + " ";
                MessageBox.Show(csimple + where);
                txtCadenaGenerada.Text = csimple + where;
        }

        //Adolfo Monterroso 0901-18-50
        private void btnAgregarConsultaCompleja_Click(object sender, EventArgs e)
        {
            if ((cboOperadorLogico.Text == "") || (cboCampoLogica.Text == "") || (txtValor.Text == "")||(cboandcre.Text==""))
            {
                MessageBox.Show("Utilice todos los campos logicos");
            }
            else
            {

            if (where != "")
            {

                if (cboandcre.SelectedItem.ToString() == "like") { 
                and = and + cboOperadorLogico.SelectedItem.ToString() + " "
                + cboCampoLogica.SelectedItem.ToString() + " " +
                cboandcre.SelectedItem.ToString()+" "+'"' +"%"+ txtValor.Text +" %"+ '"' + " ";
                txtCadenaGenerada.Text = csimple + where + and;
                } else {
                and = and + cboOperadorLogico.SelectedItem.ToString() + " "
                + cboCampoLogica.SelectedItem.ToString() + " " +
                cboandcre.SelectedItem.ToString() + " " + '"' + txtValor.Text + '"' + " ";
                txtCadenaGenerada.Text = csimple + where + and;
                    }
                } else
            {
                and = "";
                MessageBox.Show("Para agregar un comparador debe seleccionar un where");
            }
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void btnAgregarAgruparordenar_Click(object sender, EventArgs e)
        {
            if (rdbDesc.Checked == true)
            {
                orden = "desc";
            } else
            {
                orden = "asc";
            }

            if ((cboAgruparOrdenar.Text == "") || (cboCampoAgruparOrdenar.Text==""))
            {
                MessageBox.Show("Debe utilizar todos los campos de agrupacion");
            } else
            {
            if (cboAgruparOrdenar.SelectedIndex == 0)
            {
                group = "group by " + cboCampoAgruparOrdenar.SelectedItem.ToString();
            } else if (cboAgruparOrdenar.SelectedIndex == 1)
            {
                group = "order by " + cboCampoAgruparOrdenar.SelectedItem.ToString() + " " + orden;

            }
            txtCadenaGenerada.Text = csimple + where + and + group;
        }
        }

        //Adolfo Monterroso 0901-18-50
        private void cboAgruparOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboAgruparOrdenar.SelectedIndex == 1)
            {
                gpbOrdenamiento.Enabled = true;
            } else
            {
                gpbOrdenamiento.Enabled = false;
                rdbAsc.Checked = false;
                rdbDesc.Checked = false;
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void button1_Click(object sender, EventArgs e)
        {
            if ((cboTipoComparador.Text == "")|| (cboCampoComparacion.Text == "")|| (txtValorComparacion.Text == "")||(cbocompcre.Text==""))
            {
                MessageBox.Show("Clausula where estructurada erroneamente");
            } else
            {
                if (cbocompcre.SelectedItem.ToString()=="like")
                {
                    where = cboTipoComparador.SelectedItem.ToString() + " " + cboCampoComparacion.SelectedItem.ToString() + " " +
                    cbocompcre.SelectedItem.ToString()+" "+'"' +"%"+ txtValorComparacion.Text +"%"+ '"' + " ";
                    txtCadenaGenerada.Text = csimple + where;
                } else
                {
                    where = cboTipoComparador.SelectedItem.ToString() + " " + cboCampoComparacion.SelectedItem.ToString() + " " +
                    cbocompcre.SelectedItem.ToString() + " " + '"' + txtValorComparacion.Text + '"' + " ";
                    txtCadenaGenerada.Text = csimple + where;
                }
            }

        }

        private void cbovalidar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Adolfo Monterroso 0901-18-50
        public void actualizaconsultas()
        {
            DataTable dt = cn.llenartb2();
            dgvBUSCARyELIMINAR.DataSource = dt;
        }

        //Adolfo Monterroso 0901-18-50
        private void btnConsultaBUSCARyELIMINAR_Click(object sender, EventArgs e)
        {
            actualizaconsultas();
        }

        //Adolfo Monterroso 0901-18-50
        public void actualizaconsultas2(string condicion)
        {
            DataTable dt = cn.llenartb3(condicion);
            dgvBUSCARyELIMINAR.DataSource = dt;
        }

        //Adolfo Monterroso 0901-18-50
        private void btnBuscarBUSCARyELIMINAR_Click(object sender, EventArgs e)
        {
            actualizaconsultas2(txtNombreConsultaBUSCARyELIMINAR.Text);
        }


        //Adolfo Monterroso 0901-18-50
        private void btnEliminarBUSCARyELIMINAR_Click(object sender, EventArgs e)
        {
            cn.ejecutarconsulta(txtNombreConsultaBUSCARyELIMINAR.Text);
            MessageBox.Show("Las consultas con nombre " + txtNombreConsultaBUSCARyELIMINAR.Text + " Han sido eliminadas");
            actualizaconsultas();
            txtNombreConsultaBUSCARyELIMINAR.Text = "";
        }

        //Adolfo Monterroso 0901-18-50
        //Pestaña TAB3 EDITAR a partir de aca
        string transfiere = "";
        string campoeditar = "";
        string csimpleeditar = "";
        string whereeditar = "";
        string andeditar = "";
        string ordeneditar = "";
        string groupeditar = "";
        string finaleditar = "";
        //Adolfo Monterroso 0901-18-50
        private void btnActualizarBUSCARyELIMINAR_Click(object sender, EventArgs e)
        {
            transfiere = txtNombreConsultaBUSCARyELIMINAR.Text;
            cbonombreconsulta.Text = transfiere;
            txtTablaConsultaSimple.Text = transfiere;
            groupBox8.Enabled = true;
            tabPage4.Hide();
            tabPage3.Show();        
        }

        //Adolfo Monterroso 0901-18-50
        public void llenarcomboeditar()
        {
            cbonombreconsulta.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbonombreconsulta();
            while (datareader.Read())
            {
                cbonombreconsulta.Items.Add(datareader[0].ToString());
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void cbonombreconsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTablaConsultaSimple.Text = cbonombreconsulta.SelectedItem.ToString();
            groupBox8.Enabled = true;

        }

        //Adolfo Monterroso 0901-18-50
        private void cboTablaConsultaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttablaeditar.Text = cboTablaConsultaSimple.SelectedItem.ToString();
            llenarcombosactualizar();
            chkSelectTodosConsultaSimple.Enabled = true;
        }

        //Adolfo Monterroso 0901-18-50
        public void tablaseditar()
        {
            cboTabla.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo();
            while (datareader.Read())
            {
                cboTablaConsultaSimple.Items.Add(datareader[0].ToString());
            }
        }
        //Adolfo Monterroso 0901-18-50
        public void llenarcombosactualizar()
        {
            cboCamposEDITAR.Items.Clear();
            cboCampoConsultaComplejaEDITAR.Items.Clear();
            cboCampoEDITAR.Items.Clear();
            cboCampoAgruparEDITAR.Items.Clear();
            OdbcDataReader datareader = cn.llenarcbo2(txttablaeditar.Text);
            while (datareader.Read())
            {
                cboCamposEDITAR.Items.Add(datareader[0].ToString());
                cboCampoConsultaComplejaEDITAR.Items.Add(datareader[0].ToString());
                cboCampoEDITAR.Items.Add(datareader[0].ToString());
                cboCampoAgruparEDITAR.Items.Add(datareader[0].ToString());
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void chkSelectTodosConsultaSimple_CheckedChanged(object sender, EventArgs e)
        {

            if (chkSelectTodosConsultaSimple.Checked == true)
            {
                txtNombreRepresentativoEDITAR.Text = "";
                txtNombreRepresentativoEDITAR.Enabled = false;
                cboCamposEDITAR.Text = "";
                cboCamposEDITAR.Enabled = false;
                txtcamposelectoseditar.Text = "";
            }
            else
            {
                txtNombreRepresentativoEDITAR.Text = "";
                txtNombreRepresentativoEDITAR.Enabled = true;
                cboCamposEDITAR.Text = "";
                cboCamposEDITAR.Enabled = true;              
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void btnAgregarCONSULTASIMPLE_Click(object sender, EventArgs e)
        {
            if (chkSelectTodosConsultaSimple.Checked == false)
            {
                if (txtcamposelectoseditar.Text.Equals(""))
                {
                    if (txtNombreRepresentativoEDITAR.Text.Equals(""))
                    {
                        txtcamposelectoseditar.Text = "";
                        campoeditar = campoeditar + cboCamposEDITAR.SelectedItem.ToString() + " ";
                        txtcamposelectoseditar.Text = campoeditar;
                    }
                    else
                    {
                        txtcamposelectoseditar.Text = "";
                        campoeditar = campoeditar + cboCamposEDITAR.SelectedItem.ToString() + " as " + txtNombreRepresentativoEDITAR.Text + " ";
                        txtcamposelectoseditar.Text = campoeditar;
                    }
                }
                else
                {
                    if (txtNombreRepresentativoEDITAR.Text.Equals(""))
                    {
                        txtcamposelectoseditar.Text = "";
                        campoeditar = campoeditar + ", " + cboCamposEDITAR.SelectedItem.ToString() + " ";
                        txtcamposelectoseditar.Text = campoeditar;
                    }
                    else
                    {
                        txtcamposelectoseditar.Text = "";
                        campoeditar = campoeditar + ", " + cboCamposEDITAR.SelectedItem.ToString() + " as " + txtNombreRepresentativoEDITAR.Text + " ";
                        txtcamposelectoseditar.Text = campoeditar;
                    }
                }
            }
            else
            {
                txtcamposelectoseditar.Text = "";
                campoeditar = "";
                campoeditar = " * ";
                txtcamposelectoseditar.Text = "Todos los campos seleccionados";
                Console.WriteLine(campoeditar);
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void btnagregarcamposeditar_Click(object sender, EventArgs e)
        {
            if (campoeditar == "")
            {
                MessageBox.Show("Debe seleccionar al menos un campo");
            }
            else
            {
                csimpleeditar = "SELECT " + campoeditar + "FROM " + txttablaeditar.Text + " ";
                Console.WriteLine(csimpleeditar);
                txtCadenaGeneradaEDITAR.Text = csimpleeditar;
                campoeditar = "";
                txtNombreRepresentativoEDITAR.Text = "";
                cboCamposEDITAR.Text = "";
                txtcamposelectoseditar.Text = "";
                cboTablaConsultaSimple.Text = "";
                chkSelectTodosConsultaSimple.Checked = false;
                cbonombreconsulta.Enabled = false;
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void chkcondicioneseditar_CheckedChanged(object sender, EventArgs e)
        {
            if ((chkcondicioneseditar.Checked == true) && (csimpleeditar != ""))
            {
                groupBox9.Enabled = true;
                groupBox12.Enabled = true;
            }
            else
            {
                groupBox9.Enabled = false;
                groupBox12.Enabled = false;
                chkcondicioneseditar.Checked = false;
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void btnAgregarComparacionEDITAR_Click(object sender, EventArgs e)
        {
            if ((cboTipoComparadorEDITAR.Text == "") || (cboCampoEDITAR.Text == "") || (txtValorComparacionEDITAR.Text == "")||(cbocompwhere.Text==""))
            {
                MessageBox.Show("Clausula where estructurada erroneamente");
            }
            else
            {
                if (cbocompwhere.SelectedItem.ToString() == "like")
                {
                 whereeditar = cboTipoComparadorEDITAR.SelectedItem.ToString() + " " + cboCampoEDITAR.SelectedItem.ToString() + " " +
                 cbocompwhere.SelectedItem.ToString()+" "+'"' + "%" + txtValorComparacionEDITAR.Text +"%"+ '"' + " ";
                 txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar;
                } else { 
                whereeditar = cboTipoComparadorEDITAR.SelectedItem.ToString() + " " + cboCampoEDITAR.SelectedItem.ToString() + " " +
                cbocompwhere.SelectedItem.ToString()+'"' + txtValorComparacionEDITAR.Text + '"' + " ";
                txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar;
                }
            }

        }

        //Adolfo Monterroso 0901-18-50
        private void btnagregarCONSULTACOMPLEJAEDITAR_Click(object sender, EventArgs e)
        {
            if ((cboOperadorLogicoEDITAR.Text == "") || (cboCampoConsultaComplejaEDITAR.Text == "") || (txtvalorConsultaComplejaEDITAR.Text == ""))
            {
                MessageBox.Show("Utilice todos los campos logicos");
            }
            else
            {

                if (whereeditar != "")
                {
                    if (cbocompand.SelectedItem.ToString() == "like")
                    {
                        andeditar = andeditar + cboOperadorLogicoEDITAR.SelectedItem.ToString() + " "
                         + cboCampoConsultaComplejaEDITAR.SelectedItem.ToString() + " " +
                        cbocompand.SelectedItem.ToString()+" "+'"' +"%"+ txtvalorConsultaComplejaEDITAR.Text +" %"+ '"' + " ";
                        txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar + andeditar;
                    }
                    else
                    {
                        andeditar = andeditar + cboOperadorLogicoEDITAR.SelectedItem.ToString() + " "
                         + cboCampoConsultaComplejaEDITAR.SelectedItem.ToString() + " " +
                        cbocompand.SelectedItem.ToString() + " " + '"' + txtvalorConsultaComplejaEDITAR.Text + '"' + " ";
                        txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar + andeditar;
                    }
                }
                else
                {
                    andeditar = "";
                    MessageBox.Show("Para agregar un comparador debe seleccionar un where");


                }
            }
        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void gpbOrdenamiento_Enter(object sender, EventArgs e)
        {

        }

        //Adolfo Monterroso 0901-18-50
        private void btnAgregarAgruparOrdenarEDITAR_Click(object sender, EventArgs e)
        {
            if (rdbdescEDITAR.Checked == true)
            {
                ordeneditar = "desc";
            }
            else
            {
                ordeneditar = "asc";
            }


            if ((cboAgruparEDITAR.Text == "") || (cboCampoAgruparEDITAR.Text == ""))
            {
                MessageBox.Show("Debe utilizar todos los campos de agrupacion");
            }
            else
            {
                if (cboAgruparEDITAR.SelectedIndex == 0)
                {
                    groupeditar = "group by " + cboCampoAgruparEDITAR.SelectedItem.ToString();
                }
                else if (cboAgruparEDITAR.SelectedIndex == 1)
                {
                    groupeditar = "order by " + cboCampoAgruparEDITAR.SelectedItem.ToString() + " " + ordeneditar;

                }
                txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar + andeditar + groupeditar;
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void cboAgruparEDITAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAgruparEDITAR.SelectedIndex == 1)
            {
                groupBox13.Enabled = true;
            }
            else
            {
                groupBox13.Enabled = false;
                rdbAscEDITAR.Checked = false;
                rdbdescEDITAR.Checked = false;
            }
        }

        //Adolfo Monterroso 0901-18-50
        private void btneditar_Click(object sender, EventArgs e)
        {
            finaleditar = csimpleeditar + " " + whereeditar + " " + andeditar + " " + groupeditar + ";";
            if (csimpleeditar == "")
            {
                MessageBox.Show("Consulta incorrecta");
            }
            else
            {
                MessageBox.Show("Consulta Almacenada");
                cn.editarconsulta(txtTablaConsultaSimple.Text, finaleditar);
                llenarcboquery();
            }
            txtCadenaGeneradaEDITAR.Text = "";
            chkcondicioneseditar.Checked = false;
            txtcamposelectoseditar.Text = "";
            txtNombreRepresentativoEDITAR.Text = "";
            finaleditar = "";
            csimpleeditar = "";
            whereeditar = "";
            andeditar = "";
            groupeditar = "";
            cbonombreconsulta.Text = "";
            cbonombreconsulta.Enabled = true;
        
        }

        //Adolfo Monterroso 0901-18-50
        private void btnCancelarCONSULTASIMPLE_Click(object sender, EventArgs e)
        {
            csimpleeditar ="";
            txtCadenaGeneradaEDITAR.Text ="";
            campoeditar = "";
            txtNombreRepresentativoEDITAR.Text = "";
            cboCamposEDITAR.Text = "";
            txtcamposelectoseditar.Text = "";
            cboTablaConsultaSimple.Text = "";
            chkSelectTodosConsultaSimple.Checked = false;
            cbonombreconsulta.Enabled = true;
            campoeditar = "";
            whereeditar = "";
            andeditar = "";
            groupeditar = "";
        }

        //Adolfo Monterroso 0901-18-50
        private void txtcancelarComparacionEDITAR_Click(object sender, EventArgs e)
        {
            cboTipoComparadorEDITAR.Text = "";
            cboCampoEDITAR.Text = "";
            txtValorComparacionEDITAR.Text = "";
            whereeditar = "";
            txtCadenaGeneradaEDITAR.Text = csimpleeditar;
            andeditar = "";
        }

        //Adolfo Monterroso 0901-18-50
        private void btnCancelarCONSULTACOMPLEJAEDITAR_Click(object sender, EventArgs e)
        {
            cboOperadorLogicoEDITAR.Text = "";
            cboCampoConsultaComplejaEDITAR.Text = "";
            txtvalorConsultaComplejaEDITAR.Text = "";
            andeditar = "";
            txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar + groupeditar;
        }

        //Adolfo Monterroso 0901-18-50
        private void btnCancelarAgruparOrdenarEDITAR_Click(object sender, EventArgs e)
        {
            groupBox13.Enabled = false;
            rdbdescEDITAR.Checked = false;
            rdbAscEDITAR.Checked = false;
            cboAgruparEDITAR.Text = "";
            cboCampoAgruparEDITAR.Text = "";
            groupeditar = "";
            txtCadenaGeneradaEDITAR.Text = csimpleeditar + whereeditar + andeditar;
        }

        //Adolfo Monterroso 0901-18-50
        private void btnborrareditar_Click(object sender, EventArgs e)
        {
            campoeditar = "";
            csimpleeditar = "";
            whereeditar = "";
            andeditar = "";
            groupeditar = "";
            finaleditar = "";
            txtCadenaGeneradaEDITAR.Text = "";
            groupBox13.Enabled = false;
            rdbdescEDITAR.Checked = false;
            rdbAscEDITAR.Checked = false;
            cboAgruparEDITAR.Text = "";
            cboCampoAgruparEDITAR.Text = "";
            cboOperadorLogicoEDITAR.Text = "";
            cboCampoConsultaComplejaEDITAR.Text = "";
            txtvalorConsultaComplejaEDITAR.Text = "";
            cboTipoComparador.Text = "";
            cboCampoEDITAR.Text = "";
            txtValorComparacionEDITAR.Text = "";
            txtNombreRepresentativoEDITAR.Text = "";
            cboCamposEDITAR.Text = "";
            txtcamposelectoseditar.Text = "";
            cboTablaConsultaSimple.Text = "";
            chkSelectTodosConsultaSimple.Checked = false;
            cboTipoComparadorEDITAR.Text = "";
            txtTablaConsultaSimple.Text = "";
            cbonombreconsulta.Enabled = true;
            cbonombreconsulta.Text = "";
            chkcondicioneseditar.Checked = false;
        }

        //Adolfo Monterroso 0901-18-50
        private void cbotablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            valortabla.Text = cbotablas.SelectedItem.ToString();
            if (cbotablas.Text == "")
            {
                chkSelectTodos.Enabled = false;
            }
            else
            {
                chkSelectTodos.Enabled = true;
            }
            llenarcombo2();

        }

        private void cbocompwhere_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
