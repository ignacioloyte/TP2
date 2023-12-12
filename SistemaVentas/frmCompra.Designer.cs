namespace CapaPresentacion
{
    partial class frmCompra
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label9 = new Label();
            lblRegistrar = new Label();
            gbInfoCompra = new GroupBox();
            txtFecha = new TextBox();
            cbDoc = new ComboBox();
            lblDoc = new Label();
            lblFecha = new Label();
            txtNombreProveedor = new ComboBox();
            lblRazonSocial = new Label();
            txtDocProveedor = new ComboBox();
            lblNroDoc = new Label();
            gbInfoProveedor = new GroupBox();
            txtIdProveedor = new TextBox();
            btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            gbInfoProducto = new GroupBox();
            txtCantidad = new NumericUpDown();
            lblCantidad = new Label();
            txtPrecioVenta = new TextBox();
            lblPrecioVenta = new Label();
            txtPrecioCompra = new TextBox();
            lblPrecioCompra = new Label();
            txtProducto = new TextBox();
            txtIdProducto = new TextBox();
            txtCodProducto = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            lblProducto = new Label();
            lblCodProducto = new Label();
            dgvData = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Productos = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            txtTotalPagar = new TextBox();
            lblTotalPagar = new Label();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            gbInfoCompra.SuspendLayout();
            gbInfoProveedor.SuspendLayout();
            gbInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(150, 5);
            label9.Name = "label9";
            label9.Padding = new Padding(8);
            label9.Size = new Size(956, 670);
            label9.TabIndex = 22;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = SystemColors.Window;
            lblRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrar.Location = new Point(168, 19);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(200, 31);
            lblRegistrar.TabIndex = 23;
            lblRegistrar.Text = "Registrar Compra";
            // 
            // gbInfoCompra
            // 
            gbInfoCompra.BackColor = Color.White;
            gbInfoCompra.Controls.Add(txtFecha);
            gbInfoCompra.Controls.Add(cbDoc);
            gbInfoCompra.Controls.Add(lblDoc);
            gbInfoCompra.Controls.Add(lblFecha);
            gbInfoCompra.Location = new Point(179, 68);
            gbInfoCompra.Name = "gbInfoCompra";
            gbInfoCompra.Size = new Size(409, 109);
            gbInfoCompra.TabIndex = 24;
            gbInfoCompra.TabStop = false;
            gbInfoCompra.Text = "Información Compra";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(18, 60);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(156, 27);
            txtFecha.TabIndex = 35;
            // 
            // cbDoc
            // 
            cbDoc.Enabled = false;
            cbDoc.FormattingEnabled = true;
            cbDoc.Location = new Point(182, 60);
            cbDoc.Name = "cbDoc";
            cbDoc.Size = new Size(206, 28);
            cbDoc.TabIndex = 3;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(182, 37);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(124, 20);
            lblDoc.TabIndex = 2;
            lblDoc.Text = "Tipo Documento:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(15, 36);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.FormattingEnabled = true;
            txtNombreProveedor.Location = new Point(251, 60);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(233, 28);
            txtNombreProveedor.TabIndex = 3;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(251, 37);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(97, 20);
            lblRazonSocial.TabIndex = 2;
            lblRazonSocial.Text = "Razón Social:";
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.FormattingEnabled = true;
            txtDocProveedor.Location = new Point(15, 59);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(178, 28);
            txtDocProveedor.TabIndex = 1;
            // 
            // lblNroDoc
            // 
            lblNroDoc.AutoSize = true;
            lblNroDoc.Location = new Point(15, 36);
            lblNroDoc.Name = "lblNroDoc";
            lblNroDoc.Size = new Size(148, 20);
            lblNroDoc.TabIndex = 0;
            lblNroDoc.Text = "Número Documento:";
            // 
            // gbInfoProveedor
            // 
            gbInfoProveedor.BackColor = Color.White;
            gbInfoProveedor.Controls.Add(txtIdProveedor);
            gbInfoProveedor.Controls.Add(btnBuscarProveedor);
            gbInfoProveedor.Controls.Add(txtNombreProveedor);
            gbInfoProveedor.Controls.Add(lblRazonSocial);
            gbInfoProveedor.Controls.Add(txtDocProveedor);
            gbInfoProveedor.Controls.Add(lblNroDoc);
            gbInfoProveedor.Location = new Point(603, 68);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Size = new Size(491, 109);
            gbInfoProveedor.TabIndex = 25;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Información Proveedor";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(437, 25);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(47, 27);
            txtIdProveedor.TabIndex = 26;
            txtIdProveedor.Visible = false;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.BackColor = Color.White;
            btnBuscarProveedor.Cursor = Cursors.Hand;
            btnBuscarProveedor.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProveedor.FlatStyle = FlatStyle.Flat;
            btnBuscarProveedor.ForeColor = Color.White;
            btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProveedor.IconColor = Color.Black;
            btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProveedor.IconSize = 27;
            btnBuscarProveedor.Location = new Point(199, 59);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(46, 29);
            btnBuscarProveedor.TabIndex = 27;
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // gbInfoProducto
            // 
            gbInfoProducto.BackColor = Color.White;
            gbInfoProducto.Controls.Add(txtCantidad);
            gbInfoProducto.Controls.Add(lblCantidad);
            gbInfoProducto.Controls.Add(txtPrecioVenta);
            gbInfoProducto.Controls.Add(lblPrecioVenta);
            gbInfoProducto.Controls.Add(txtPrecioCompra);
            gbInfoProducto.Controls.Add(lblPrecioCompra);
            gbInfoProducto.Controls.Add(txtProducto);
            gbInfoProducto.Controls.Add(txtIdProducto);
            gbInfoProducto.Controls.Add(txtCodProducto);
            gbInfoProducto.Controls.Add(btnBuscarProducto);
            gbInfoProducto.Controls.Add(lblProducto);
            gbInfoProducto.Controls.Add(lblCodProducto);
            gbInfoProducto.Location = new Point(179, 184);
            gbInfoProducto.Name = "gbInfoProducto";
            gbInfoProducto.Size = new Size(807, 109);
            gbInfoProducto.TabIndex = 28;
            gbInfoProducto.TabStop = false;
            gbInfoProducto.Text = "Información Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(699, 59);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(91, 27);
            txtCantidad.TabIndex = 29;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(699, 36);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 34;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(583, 59);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(110, 27);
            txtPrecioVenta.TabIndex = 33;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(583, 35);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(94, 20);
            lblPrecioVenta.TabIndex = 32;
            lblPrecioVenta.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(463, 59);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(110, 27);
            txtPrecioCompra.TabIndex = 31;
            txtPrecioCompra.KeyPress += txtPrecioCompra_KeyPress;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(463, 36);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(110, 20);
            lblPrecioCompra.TabIndex = 30;
            lblPrecioCompra.Text = "Precio Compra:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(251, 60);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(206, 27);
            txtProducto.TabIndex = 29;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(142, 29);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(47, 27);
            txtIdProducto.TabIndex = 28;
            txtIdProducto.Visible = false;
            // 
            // txtCodProducto
            // 
            txtCodProducto.Location = new Point(18, 61);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(175, 27);
            txtCodProducto.TabIndex = 28;
            txtCodProducto.KeyDown += txtCodProducto_KeyDown;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.White;
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProducto.IconColor = Color.Black;
            btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProducto.IconSize = 27;
            btnBuscarProducto.Location = new Point(199, 59);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(46, 29);
            btnBuscarProducto.TabIndex = 27;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(251, 37);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto:";
            // 
            // lblCodProducto
            // 
            lblCodProducto.AutoSize = true;
            lblCodProducto.Location = new Point(15, 36);
            lblCodProducto.Name = "lblCodProducto";
            lblCodProducto.Size = new Size(106, 20);
            lblCodProducto.TabIndex = 0;
            lblCodProducto.Text = "Cód. Producto:";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Productos, PrecioCompra, PrecioVenta, Cantidad, Subtotal, btnEliminar });
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(179, 300);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(807, 341);
            dgvData.TabIndex = 35;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            IdProducto.Width = 125;
            // 
            // Productos
            // 
            Productos.HeaderText = "Productos";
            Productos.MinimumWidth = 6;
            Productos.Name = "Productos";
            Productos.ReadOnly = true;
            Productos.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 150;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Visible = false;
            PrecioVenta.Width = 180;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 150;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 125;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Resizable = DataGridViewTriState.True;
            btnEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEliminar.Width = 30;
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregar.IconColor = Color.OrangeRed;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(993, 196);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 97);
            btnAgregar.TabIndex = 36;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += iconButton1_Click;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(995, 548);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(99, 27);
            txtTotalPagar.TabIndex = 36;
            txtTotalPagar.Text = "0";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Location = new Point(995, 524);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(98, 20);
            lblTotalPagar.TabIndex = 35;
            lblTotalPagar.Text = "Total a Pagar:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnRegistrar.IconColor = Color.OrangeRed;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.IconSize = 25;
            btnRegistrar.Location = new Point(995, 585);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(102, 52);
            btnRegistrar.TabIndex = 37;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrarCompra_Click;
            // 
            // frmCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 787);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTotalPagar);
            Controls.Add(lblTotalPagar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvData);
            Controls.Add(gbInfoProducto);
            Controls.Add(gbInfoProveedor);
            Controls.Add(gbInfoCompra);
            Controls.Add(lblRegistrar);
            Controls.Add(label9);
            Name = "frmCompra";
            Text = "Form1";
            Load += frmRegistrarCompra_Load;
            gbInfoCompra.ResumeLayout(false);
            gbInfoCompra.PerformLayout();
            gbInfoProveedor.ResumeLayout(false);
            gbInfoProveedor.PerformLayout();
            gbInfoProducto.ResumeLayout(false);
            gbInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label lblRegistrar;
        private GroupBox gbInfoCompra;
        private Label lblFecha;
        private ComboBox cbDoc;
        private Label lblDoc;
        private ComboBox txtNombreProveedor;
        private Label lblRazonSocial;
        private ComboBox txtDocProveedor;
        private Label lblNroDoc;
        private GroupBox gbInfoProveedor;
        private TextBox txtIdProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private GroupBox gbInfoProducto;
        private TextBox txtCodProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private Label lblProducto;
        private Label lblCodProducto;
        private NumericUpDown txtCantidad;
        private Label lblCantidad;
        private TextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private TextBox txtPrecioCompra;
        private Label lblPrecioCompra;
        private TextBox txtProducto;
        private TextBox txtIdProducto;
        private DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Productos;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn btnEliminar;
        private TextBox txtTotalPagar;
        private Label lblTotalPagar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private TextBox txtFecha;
    }
}