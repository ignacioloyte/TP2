namespace CapaPresentacion
{
    partial class frmBitacora
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnExcel = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
            label2 = new Label();
            btnBuscarS = new FontAwesome.Sharp.IconButton();
            lblFechaFin = new Label();
            dtFechaFin = new DateTimePicker();
            lblFechaInicio = new Label();
            lblRegistrar = new Label();
            dtInicio = new DateTimePicker();
            label1 = new Label();
            btnAyuda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.White;
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.FlatAppearance.BorderColor = Color.Black;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcel.ForeColor = Color.Black;
            btnExcel.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnExcel.IconColor = Color.Black;
            btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcel.IconSize = 27;
            btnExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcel.Location = new Point(27, 154);
            btnExcel.Margin = new Padding(3, 2, 3, 2);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(172, 22);
            btnExcel.TabIndex = 77;
            btnExcel.Text = "Descargar Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(27, 197);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(991, 409);
            dgvData.TabIndex = 71;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(1019, 502);
            label2.TabIndex = 70;
            // 
            // btnBuscarS
            // 
            btnBuscarS.BackColor = Color.White;
            btnBuscarS.Cursor = Cursors.Hand;
            btnBuscarS.FlatAppearance.BorderColor = Color.Black;
            btnBuscarS.FlatStyle = FlatStyle.Flat;
            btnBuscarS.ForeColor = Color.Black;
            btnBuscarS.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarS.IconColor = Color.Black;
            btnBuscarS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarS.IconSize = 15;
            btnBuscarS.Location = new Point(496, 81);
            btnBuscarS.Margin = new Padding(3, 2, 3, 2);
            btnBuscarS.Name = "btnBuscarS";
            btnBuscarS.Size = new Size(77, 24);
            btnBuscarS.TabIndex = 67;
            btnBuscarS.Text = "Buscar ";
            btnBuscarS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarS.UseVisualStyleBackColor = false;
            btnBuscarS.Click += btnBuscarProveedor_Click;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(278, 88);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(60, 15);
            lblFechaFin.TabIndex = 66;
            lblFechaFin.Text = "Fecha Fin:";
            // 
            // dtFechaFin
            // 
            dtFechaFin.CustomFormat = "dd/MM/yyyy";
            dtFechaFin.Format = DateTimePickerFormat.Short;
            dtFechaFin.Location = new Point(357, 82);
            dtFechaFin.Name = "dtFechaFin";
            dtFechaFin.Size = new Size(125, 23);
            dtFechaFin.TabIndex = 65;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(27, 90);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(73, 15);
            lblFechaInicio.TabIndex = 64;
            lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = SystemColors.Window;
            lblRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrar.Location = new Point(27, 45);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(189, 25);
            lblRegistrar.TabIndex = 63;
            lblRegistrar.Text = "Reporte de Bitácora";
            lblRegistrar.Click += lblRegistrar_Click;
            // 
            // dtInicio
            // 
            dtInicio.CustomFormat = "dd/MM/yyyy";
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(106, 84);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(125, 23);
            dtInicio.TabIndex = 61;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(1019, 96);
            label1.TabIndex = 62;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.White;
            btnAyuda.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAyuda.ForeColor = SystemColors.ControlLightLight;
            btnAyuda.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnAyuda.IconColor = Color.DarkOrange;
            btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAyuda.IconSize = 38;
            btnAyuda.Location = new Point(981, 40);
            btnAyuda.Margin = new Padding(3, 2, 3, 2);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(38, 28);
            btnAyuda.TabIndex = 78;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // frmBitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 672);
            Controls.Add(btnAyuda);
            Controls.Add(btnExcel);
            Controls.Add(dgvData);
            Controls.Add(label2);
            Controls.Add(btnBuscarS);
            Controls.Add(lblFechaFin);
            Controls.Add(dtFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblRegistrar);
            Controls.Add(dtInicio);
            Controls.Add(label1);
            Name = "frmBitacora";
            Text = "Bitácora";
            Load += frmReporteVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnExcel;
        private DataGridView dgvData;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscarS;
        private Label lblFechaFin;
        private DateTimePicker dtFechaFin;
        private Label lblFechaInicio;
        private Label lblRegistrar;
        private DateTimePicker dtInicio;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnAyuda;
    }
}