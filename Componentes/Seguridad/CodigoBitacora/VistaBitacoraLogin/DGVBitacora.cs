using BitacoraRegistrarLogin.ViewModel;
using BitacoraUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaBitacora
{
    public partial class DGVBitacora : DataGridView
    {
        /// JORGE GONZÁLEZ
        /// <summary>
        /// Se especifican los parámetros del Data Grid View
        /// </summary>
        public DGVBitacora()
        {
            actualizarBitacora();
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RowHeadersVisible = false;
            this.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                WrapMode = DataGridViewTriState.True,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding { Left = 5, Top = 5, Right = 5, Bottom = 5 }
            };

            this.RowHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                WrapMode = DataGridViewTriState.True,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding { Left = 3, Top = 3, Right = 3, Bottom = 3 }
            };
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        /// MELANIE REVOLORIO
        /// <summary>
        /// Botón para actualizar la bitácora
        /// </summary>
        public void actualizarBitacora()
        {
            Bitacora m = new Bitacora();
            var list = m.leerBitacora();
            var bindingList = new BindingList<ViewModelBitacora>(list);
            var source = new BindingSource(bindingList, null);
            this.DataSource = source;
        }
    }
}