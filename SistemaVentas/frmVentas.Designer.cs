namespace CapaPresentacion
{
    partial class frmVentas
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
            btnCrearVenta = new FontAwesome.Sharp.IconButton();
            txtTotalPagar = new TextBox();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            lblTotalPagar = new Label();
            dgvData = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            txtCantidad = new NumericUpDown();
            lblCantidad = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            label9 = new Label();
            gbInfo = new GroupBox();
            txtFecha = new TextBox();
            cbTipoDoc = new ComboBox();
            lblDoc = new Label();
            lblFecha = new Label();
            lblRegistrar = new Label();
            gbInfoProducto = new GroupBox();
            lblPrecio = new Label();
            txtProducto = new TextBox();
            txtIdProducto = new TextBox();
            txtCodProducto = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            lblProducto = new Label();
            lblCodProducto = new Label();
            btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            lblNombreCliente = new Label();
            gbInfoCliente = new GroupBox();
            txtNombreCliente = new TextBox();
            txtDocCliente = new TextBox();
            lblNroDoc = new Label();
            txtPagaCon = new TextBox();
            lblPagaCon = new Label();
            txtCambio = new TextBox();
            lblCambio = new Label();
            btnAyuda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            gbInfo.SuspendLayout();
            gbInfoProducto.SuspendLayout();
            gbInfoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrearVenta
            // 
            btnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnCrearVenta.IconColor = Color.OrangeRed;
            btnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearVenta.IconSize = 25;
            btnCrearVenta.Location = new Point(896, 592);
            btnCrearVenta.Margin = new Padding(3, 4, 3, 4);
            btnCrearVenta.Name = "btnCrearVenta";
            btnCrearVenta.Size = new Size(102, 52);
            btnCrearVenta.TabIndex = 47;
            btnCrearVenta.Text = "Crear Venta";
            btnCrearVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearVenta.UseVisualStyleBackColor = true;
            btnCrearVenta.Click += btnCrearVenta_Click;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Enabled = false;
            txtTotalPagar.Location = new Point(894, 415);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(99, 27);
            txtTotalPagar.TabIndex = 45;
            txtTotalPagar.Text = "0";
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregar.IconColor = Color.OrangeRed;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(894, 203);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 97);
            btnAgregar.TabIndex = 46;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Location = new Point(894, 391);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(98, 20);
            lblTotalPagar.TabIndex = 43;
            lblTotalPagar.Text = "Total a Pagar:";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, Subtotal, btnEliminar });
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(80, 307);
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
            dgvData.Size = new Size(807, 341);
            dgvData.TabIndex = 44;
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
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio ";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 150;
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
            lblCantidad.Location = new Point(699, 35);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 34;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Location = new Point(583, 59);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(110, 27);
            txtStock.TabIndex = 33;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(583, 33);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 32;
            lblStock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(463, 59);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 27);
            txtPrecio.TabIndex = 31;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(50, 12);
            label9.Name = "label9";
            label9.Padding = new Padding(8);
            label9.Size = new Size(956, 670);
            label9.TabIndex = 38;
            // 
            // gbInfo
            // 
            gbInfo.BackColor = Color.White;
            gbInfo.Controls.Add(txtFecha);
            gbInfo.Controls.Add(cbTipoDoc);
            gbInfo.Controls.Add(lblDoc);
            gbInfo.Controls.Add(lblFecha);
            gbInfo.Location = new Point(80, 75);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(409, 109);
            gbInfo.TabIndex = 40;
            gbInfo.TabStop = false;
            gbInfo.Text = "Información Venta";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(18, 60);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(156, 27);
            txtFecha.TabIndex = 35;
            // 
            // cbTipoDoc
            // 
            cbTipoDoc.Enabled = false;
            cbTipoDoc.FormattingEnabled = true;
            cbTipoDoc.Location = new Point(182, 60);
            cbTipoDoc.Name = "cbTipoDoc";
            cbTipoDoc.Size = new Size(206, 28);
            cbTipoDoc.TabIndex = 3;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(182, 36);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(124, 20);
            lblDoc.TabIndex = 2;
            lblDoc.Text = "Tipo Documento:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(15, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = SystemColors.Window;
            lblRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrar.Location = new Point(69, 25);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(177, 31);
            lblRegistrar.TabIndex = 39;
            lblRegistrar.Text = "Registrar Venta";
            // 
            // gbInfoProducto
            // 
            gbInfoProducto.BackColor = Color.White;
            gbInfoProducto.Controls.Add(txtCantidad);
            gbInfoProducto.Controls.Add(lblCantidad);
            gbInfoProducto.Controls.Add(txtStock);
            gbInfoProducto.Controls.Add(lblStock);
            gbInfoProducto.Controls.Add(txtPrecio);
            gbInfoProducto.Controls.Add(lblPrecio);
            gbInfoProducto.Controls.Add(txtProducto);
            gbInfoProducto.Controls.Add(txtIdProducto);
            gbInfoProducto.Controls.Add(txtCodProducto);
            gbInfoProducto.Controls.Add(btnBuscarProducto);
            gbInfoProducto.Controls.Add(lblProducto);
            gbInfoProducto.Controls.Add(lblCodProducto);
            gbInfoProducto.Location = new Point(80, 191);
            gbInfoProducto.Name = "gbInfoProducto";
            gbInfoProducto.Size = new Size(807, 109);
            gbInfoProducto.TabIndex = 42;
            gbInfoProducto.TabStop = false;
            gbInfoProducto.Text = "Información Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(463, 35);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 30;
            lblPrecio.Text = "Precio:";
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
            lblProducto.Location = new Point(251, 36);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto:";
            // 
            // lblCodProducto
            // 
            lblCodProducto.AutoSize = true;
            lblCodProducto.Location = new Point(15, 35);
            lblCodProducto.Name = "lblCodProducto";
            lblCodProducto.Size = new Size(106, 20);
            lblCodProducto.TabIndex = 0;
            lblCodProducto.Text = "Cód. Producto:";
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
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(251, 36);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(137, 20);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "Nombre Completo:";
            // 
            // gbInfoCliente
            // 
            gbInfoCliente.BackColor = Color.White;
            gbInfoCliente.Controls.Add(txtNombreCliente);
            gbInfoCliente.Controls.Add(txtDocCliente);
            gbInfoCliente.Controls.Add(btnBuscarProveedor);
            gbInfoCliente.Controls.Add(lblNombreCliente);
            gbInfoCliente.Controls.Add(lblNroDoc);
            gbInfoCliente.Location = new Point(504, 75);
            gbInfoCliente.Name = "gbInfoCliente";
            gbInfoCliente.Size = new Size(491, 109);
            gbInfoCliente.TabIndex = 41;
            gbInfoCliente.TabStop = false;
            gbInfoCliente.Text = "Información Cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(251, 59);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(228, 27);
            txtNombreCliente.TabIndex = 37;
            // 
            // txtDocCliente
            // 
            txtDocCliente.Location = new Point(7, 60);
            txtDocCliente.Name = "txtDocCliente";
            txtDocCliente.Size = new Size(185, 27);
            txtDocCliente.TabIndex = 36;
            // 
            // lblNroDoc
            // 
            lblNroDoc.AutoSize = true;
            lblNroDoc.Location = new Point(15, 35);
            lblNroDoc.Name = "lblNroDoc";
            lblNroDoc.Size = new Size(148, 20);
            lblNroDoc.TabIndex = 0;
            lblNroDoc.Text = "Número Documento:";
            // 
            // txtPagaCon
            // 
            txtPagaCon.Location = new Point(894, 487);
            txtPagaCon.Name = "txtPagaCon";
            txtPagaCon.Size = new Size(99, 27);
            txtPagaCon.TabIndex = 49;
            txtPagaCon.Text = "0";
            txtPagaCon.KeyDown += txtPagaCon_KeyDown;
            txtPagaCon.KeyPress += txtPagaCon_KeyPress;
            // 
            // lblPagaCon
            // 
            lblPagaCon.AutoSize = true;
            lblPagaCon.Location = new Point(894, 463);
            lblPagaCon.Name = "lblPagaCon";
            lblPagaCon.Size = new Size(72, 20);
            lblPagaCon.TabIndex = 48;
            lblPagaCon.Text = "Paga con:";
            // 
            // txtCambio
            // 
            txtCambio.Enabled = false;
            txtCambio.Location = new Point(894, 555);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(99, 27);
            txtCambio.TabIndex = 51;
            txtCambio.Text = "0";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Location = new Point(894, 531);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(64, 20);
            lblCambio.TabIndex = 50;
            lblCambio.Text = "Cambio:";
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
            btnAyuda.Location = new Point(931, 31);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(52, 38);
            btnAyuda.TabIndex = 52;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 1189);
            Controls.Add(btnAyuda);
            Controls.Add(txtCambio);
            Controls.Add(lblCambio);
            Controls.Add(txtPagaCon);
            Controls.Add(lblPagaCon);
            Controls.Add(btnCrearVenta);
            Controls.Add(txtTotalPagar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTotalPagar);
            Controls.Add(dgvData);
            Controls.Add(gbInfo);
            Controls.Add(lblRegistrar);
            Controls.Add(gbInfoProducto);
            Controls.Add(gbInfoCliente);
            Controls.Add(label9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVentas";
            Text = "frmRegistrarVenta";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            gbInfoProducto.ResumeLayout(false);
            gbInfoProducto.PerformLayout();
            gbInfoCliente.ResumeLayout(false);
            gbInfoCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCrearVenta;
        private TextBox txtTotalPagar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label lblTotalPagar;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn btnEliminar;
        private NumericUpDown txtCantidad;
        private Label lblCantidad;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtPrecio;
        private Label label9;
        private GroupBox gbInfo;
        private TextBox txtFecha;
        private ComboBox cbTipoDoc;
        private Label lblDoc;
        private Label lblFecha;
        private Label lblRegistrar;
        private GroupBox gbInfoProducto;
        private Label lblPrecio;
        private TextBox txtProducto;
        private TextBox txtIdProducto;
        private TextBox txtCodProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private Label lblProducto;
        private Label lblCodProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private Label lblNombreCliente;
        private GroupBox gbInfoCliente;
        private TextBox txtNombreCliente;
        private TextBox txtDocCliente;
        private Label lblNroDoc;
        private TextBox txtPagaCon;
        private Label lblPagaCon;
        private TextBox txtCambio;
        private Label lblCambio;
        private FontAwesome.Sharp.IconButton btnAyuda;
    }
}