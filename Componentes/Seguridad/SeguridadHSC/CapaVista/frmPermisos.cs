using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using static datosUsuario;
//Forma Creada por Heydi Quemé 9959-18-5335
namespace CapaVistaSeguridadHSC
{
    public partial class frmPermisos : Form
    {
        private Controlador con = new Controlador();

        private int escribir = 0;
        private int leer = 0;
        private int modificar = 0;
        private int eliminar = 0;
        private int imprimir = 0;

        private int Perfil = 0;
        private int Usuario = 0;

        public frmPermisos()
        {
            InitializeComponent();
            llenarcbxAplicacion();
            actualizarpermisosUA();
            actualizarpermisosPA();
            CenterToScreen();
            bnUsuario.Checked = false;
            rbPerfil.Checked = false;
        }
        //Heydi Quemé 9959-18-5335
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Bitacora loggear = new Bitacora();
            loggear.guardarEnBitacora(IdUsuario, "1", "0008", "Guardar");

            if (labelidentidad.Text == "")
            {
                MessageBox.Show("Debe seleccionar una entidad");
            }
            else
            {
                if (labelidaplicacion.Text == "")
                {
                    MessageBox.Show("Debe seleccionar una aplicación");
                }
                else
                {
                    if (leer == 0 && escribir == 0 && modificar == 0 && imprimir == 0 && eliminar == 0)
                    {
                        MessageBox.Show("Debe marcar al menos un permiso.");
                    }
                    else
                    {
                        if (Usuario == 1 && Perfil == 0)
                        {
                            con.InsertarUsuApl(labelidentidad.Text, labelidaplicacion.Text, escribir, leer, modificar, eliminar, imprimir);
                            string usuario = labelidentidad.Text;
                            string aplicacion = labelidaplicacion.Text;
                        }
                        else
                        {
                            if (Usuario == 0 && Perfil == 1)
                            {
                                con.InsertarPPerApl(labelidentidad.Text, labelidaplicacion.Text, escribir, leer, modificar, eliminar, imprimir);
                            }
                        }
                    }
                }
            }
            actualizarpermisosUA();
            actualizarpermisosPA();
        }
        //Heydi Quemé 9959-18-5335
        public void llenarcbxAplicacion()
        {
            try
            {
                cbxAplicacion.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxAplicacion();
                cbxAplicacion.Items.Add("Selecione una Aplicación");
                while (datareader.Read())
                {
                    cbxAplicacion.Items.Add(datareader[0].ToString());
                }
                cbxAplicacion.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
        //Heydi Quemé 9959-18-5335
        public void llenarcbxUsuario()
        {
            try
            {
                cbxEntidad.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxUsuarios();
                cbxEntidad.Items.Add("Selecione un Usuario");
                while (datareader.Read())
                {
                    cbxEntidad.Items.Add(datareader[0].ToString());
                }
                cbxEntidad.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
        //Heydi Quemé 9959-18-5335
        public void llenarcbxPerfil()
        {
            try
            {
                cbxEntidad.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxPerfil();
                cbxEntidad.Items.Add("Selecione un Perfil");
                while (datareader.Read())
                {
                    cbxEntidad.Items.Add(datareader[0].ToString());
                }
                cbxEntidad.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
        //Heydi Quemé 9959-18-5335
        public string consultaUsuario(string nombre)
        {
            string id_usuario = con.consultausuario(nombre);

            return id_usuario;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaPerfil(string nombre)
        {
            string id_perfil = con.consultaperfil(nombre);

            return id_perfil;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaAplicacion(string nombre)
        {
            string id_aplicacion = con.consultaaplicacion(nombre);

            return id_aplicacion;
        }
        //Heydi Quemé 9959-18-5335
        private void rbPerfil_CheckedChanged(object sender, EventArgs e)
        {
            Perfil = 1;
            Usuario = 0;
            llenarcbxPerfil();
        }
        //Heydi Quemé 9959-18-5335
        private void bnUsuario_CheckedChanged(object sender, EventArgs e)
        {
            Perfil = 0;
            Usuario = 1;
            llenarcbxUsuario();
        }
        //Heydi Quemé 9959-18-5335
        private void cbxEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Perfil == 1 && Usuario == 0)
            {
                labelidentidad.Text = consultaPerfil(cbxEntidad.Text.ToString());
            }
            else
            {
                if (Perfil == 0 && Usuario == 1)
                {
                    labelidentidad.Text = consultaUsuario(cbxEntidad.Text.ToString());
                }
                else
                {
                    labelidentidad.Text = "-";
                }
            }
        }
        //Heydi Quemé 9959-18-5335
        private void cbxAplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelidaplicacion.Text = consultaAplicacion(cbxAplicacion.Text.ToString());
        }
        //Heydi Quemé 9959-18-5335
        private void Escritura_CheckedChanged(object sender, EventArgs e)
        {
            if (Escritura.Checked == true)
            {
                escribir = 1;
            }
            else
            {
                escribir = 0;
            }
        }
        //Heydi Quemé 9959-18-5335
        private void Lectura_CheckedChanged(object sender, EventArgs e)
        {
            if (Lectura.Checked == true)
            {
                leer = 1;
            }
            else
            {
                leer = 0;
            }
        }
        //Heydi Quemé 9959-18-5335
        private void Modificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (Modificacion.Checked == true)
            {
                modificar = 1;
            }
            else
            {
                modificar = 0;
            }
        }
        //Heydi Quemé 9959-18-5335
        private void Eliminacion_CheckedChanged(object sender, EventArgs e)
        {
            if (Eliminacion.Checked == true)
            {
                eliminar = 1;
            }
            else
            {
                eliminar = 0;
            }
        }
        //Heydi Quemé 9959-18-5335
        private void Impresion_CheckedChanged(object sender, EventArgs e)
        {
            if (Impresion.Checked == true)
            {
                imprimir = 1;
            }
            else
            {
                imprimir = 0;
            }
        }

        private string tabla1 = "vwpermisosusuario";
        private string tabla2 = "vwpermisosperfil";
        //Heydi Quemé 9959-18-5335
        public void actualizarpermisosUA()
        {
            DataTable dt = con.llenarpermisosUA(tabla1);
            dtgPermisosUA.DataSource = dt;
        }
        //Heydi Quemé 9959-18-5335
        public void actualizarpermisosPA()
        {
            DataTable dt = con.llenarpermisosPA(tabla2);
            dtgPermisosPA.DataSource = dt;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaUsuarion(string id)
        {
            string nombre_usuario = con.consultausuarion(id);

            return nombre_usuario;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaPerfiln(string id)
        {
            string nombre_perfil = con.consultaperfiln(id);

            return nombre_perfil;
        }
        //Heydi Quemé 9959-18-5335
        public string consultaAplicacionn(string id)
        {
            string nombre_aplicacion = con.consultaaplicacionn(id);

            return nombre_aplicacion;
        }
        //Heydi Quemé 9959-18-5335
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                bnUsuario.Checked = true;
                rbPerfil.Checked = false;
                labelidentidad.Text = dtgPermisosUA.CurrentRow.Cells[5].Value.ToString();
                labelidaplicacion.Text = dtgPermisosUA.CurrentRow.Cells[7].Value.ToString();
                lbe.Text = dtgPermisosUA.CurrentRow.Cells[0].Value.ToString();
                lbl.Text = dtgPermisosUA.CurrentRow.Cells[1].Value.ToString();
                lbm.Text = dtgPermisosUA.CurrentRow.Cells[2].Value.ToString();
                lbel.Text = dtgPermisosUA.CurrentRow.Cells[3].Value.ToString();
                lbi.Text = dtgPermisosUA.CurrentRow.Cells[4].Value.ToString();

                cbxEntidad.SelectedItem = consultaUsuarion(labelidentidad.Text);
                cbxAplicacion.SelectedItem = consultaAplicacionn(labelidaplicacion.Text);

                if (lbe.Text == "" && lbl.Text == "" && lbm.Text == "" && lbi.Text == "" && lbel.Text == "")
                {
                    Escritura.Checked = false;
                    Lectura.Checked = false;
                    Modificacion.Checked = false;
                    Eliminacion.Checked = false;
                    Impresion.Checked = false;
                }
                else
                {
                    if (lbe.Text == "1")
                    {
                        Escritura.Checked = true;
                    }
                    else if (lbe.Text == "0")
                    {
                        Escritura.Checked = false;
                    }

                    if (lbl.Text == "1")
                    {
                        Lectura.Checked = true;
                    }
                    else if (lbl.Text == "0")
                    {
                        Lectura.Checked = false;
                    }

                    if (lbm.Text == "1")
                    {
                        Modificacion.Checked = true;
                    }
                    else if (lbm.Text == "0")
                    {
                        Modificacion.Checked = false;
                    }

                    if (lbel.Text == "1")
                    {
                        Eliminacion.Checked = true;
                    }
                    else if (lbel.Text == "0")
                    {
                        Eliminacion.Checked = false;
                    }

                    if (lbi.Text == "1")
                    {
                        Impresion.Checked = true;
                    }
                    else if (lbi.Text == "0")
                    {
                        Impresion.Checked = false;
                    }
                }
            }
            catch
            {
            }
        }
        //Heydi Quemé 9959-18-5335
        private void dtgPermisosPA_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                bnUsuario.Checked = false;
                rbPerfil.Checked = true;
                labelidentidad.Text = dtgPermisosPA.CurrentRow.Cells[5].Value.ToString();
                labelidaplicacion.Text = dtgPermisosPA.CurrentRow.Cells[7].Value.ToString();
                lbe.Text = dtgPermisosPA.CurrentRow.Cells[0].Value.ToString();
                lbl.Text = dtgPermisosPA.CurrentRow.Cells[1].Value.ToString();
                lbm.Text = dtgPermisosPA.CurrentRow.Cells[2].Value.ToString();
                lbel.Text = dtgPermisosPA.CurrentRow.Cells[3].Value.ToString();
                lbi.Text = dtgPermisosPA.CurrentRow.Cells[4].Value.ToString();

                cbxEntidad.SelectedItem = consultaPerfiln(labelidentidad.Text);
                cbxAplicacion.SelectedItem = consultaAplicacionn(labelidaplicacion.Text);

                if (lbe.Text == "" && lbl.Text == "" && lbm.Text == "" && lbi.Text == "" && lbel.Text == "")
                {
                    Escritura.Checked = false;
                    Lectura.Checked = false;
                    Modificacion.Checked = false;
                    Eliminacion.Checked = false;
                    Impresion.Checked = false;
                }
                else
                {
                    if (lbe.Text == "1")
                    {
                        Escritura.Checked = true;
                    }
                    else if (lbe.Text == "0")
                    {
                        Escritura.Checked = false;
                    }

                    if (lbl.Text == "1")
                    {
                        Lectura.Checked = true;
                    }
                    else if (lbl.Text == "0")
                    {
                        Lectura.Checked = false;
                    }

                    if (lbm.Text == "1")
                    {
                        Modificacion.Checked = true;
                    }
                    else if (lbm.Text == "0")
                    {
                        Modificacion.Checked = false;
                    }

                    if (lbel.Text == "1")
                    {
                        Eliminacion.Checked = true;
                    }
                    else if (lbel.Text == "0")
                    {
                        Eliminacion.Checked = false;
                    }

                    if (lbi.Text == "1")
                    {
                        Impresion.Checked = true;
                    }
                    else if (lbi.Text == "0")
                    {
                        Impresion.Checked = false;
                    }
                }
            }
            catch
            {
            }
        }

        private void labelidaplicacion_Click(object sender, EventArgs e)
        {
        }
    }
}