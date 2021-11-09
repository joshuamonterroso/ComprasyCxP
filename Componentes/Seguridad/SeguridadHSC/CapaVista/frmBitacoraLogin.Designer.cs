
namespace CapaVista
{
    partial class frmBitacoraLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBitacoraLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBitacoraLogin1 = new VistaBitacoraLogin.DGVBitacoraLogin();
            this.pkIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conexionFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conexionHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraLogin1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvBitacoraLogin1);
            this.panel1.Location = new System.Drawing.Point(80, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 449);
            this.panel1.TabIndex = 0;
            // 
            // dgvBitacoraLogin1
            // 
            this.dgvBitacoraLogin1.AutoGenerateColumns = false;
            this.dgvBitacoraLogin1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacoraLogin1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBitacoraLogin1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBitacoraLogin1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacoraLogin1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBitacoraLogin1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoraLogin1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdDataGridViewTextBoxColumn,
            this.hostDataGridViewTextBoxColumn,
            this.ipDataGridViewTextBoxColumn,
            this.conexionFechaDataGridViewTextBoxColumn,
            this.conexionHoraDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.aplicacionDataGridViewTextBoxColumn});
            this.dgvBitacoraLogin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBitacoraLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBitacoraLogin1.Location = new System.Drawing.Point(0, 0);
            this.dgvBitacoraLogin1.MultiSelect = false;
            this.dgvBitacoraLogin1.Name = "dgvBitacoraLogin1";
            this.dgvBitacoraLogin1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacoraLogin1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBitacoraLogin1.RowHeadersVisible = false;
            this.dgvBitacoraLogin1.Size = new System.Drawing.Size(902, 449);
            this.dgvBitacoraLogin1.TabIndex = 0;
            // 
            // pkIdDataGridViewTextBoxColumn
            // 
            this.pkIdDataGridViewTextBoxColumn.DataPropertyName = "pkId";
            this.pkIdDataGridViewTextBoxColumn.HeaderText = "pkId";
            this.pkIdDataGridViewTextBoxColumn.Name = "pkIdDataGridViewTextBoxColumn";
            this.pkIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            this.hostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ipDataGridViewTextBoxColumn
            // 
            this.ipDataGridViewTextBoxColumn.DataPropertyName = "ip";
            this.ipDataGridViewTextBoxColumn.HeaderText = "ip";
            this.ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            this.ipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conexionFechaDataGridViewTextBoxColumn
            // 
            this.conexionFechaDataGridViewTextBoxColumn.DataPropertyName = "conexionFecha";
            this.conexionFechaDataGridViewTextBoxColumn.HeaderText = "conexionFecha";
            this.conexionFechaDataGridViewTextBoxColumn.Name = "conexionFechaDataGridViewTextBoxColumn";
            this.conexionFechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conexionHoraDataGridViewTextBoxColumn
            // 
            this.conexionHoraDataGridViewTextBoxColumn.DataPropertyName = "conexionHora";
            this.conexionHoraDataGridViewTextBoxColumn.HeaderText = "conexionHora";
            this.conexionHoraDataGridViewTextBoxColumn.Name = "conexionHoraDataGridViewTextBoxColumn";
            this.conexionHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aplicacionDataGridViewTextBoxColumn
            // 
            this.aplicacionDataGridViewTextBoxColumn.DataPropertyName = "aplicacion";
            this.aplicacionDataGridViewTextBoxColumn.HeaderText = "aplicacion";
            this.aplicacionDataGridViewTextBoxColumn.Name = "aplicacionDataGridViewTextBoxColumn";
            this.aplicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitácora de Inicio de Sesión";
            // 
            // frmBitacoraLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBitacoraLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBitacoraLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraLogin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private VistaBitacoraLogin.DGVBitacoraLogin dgvBitacoraLogin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conexionFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conexionHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacionDataGridViewTextBoxColumn;
    }
}