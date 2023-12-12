namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            label1 = new Label();
            lblDetalleCompra = new Label();
            btnBuscarS = new FontAwesome.Sharp.IconButton();
            txtBusquedaDoc = new TextBox();
            lblNroDoc = new Label();
            btnLimpiarForm = new FontAwesome.Sharp.IconButton();
            gboInfoCompra = new GroupBox();
            txtTipoDocumento = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtFecha = new TextBox();
            lblDoc = new Label();
            lblFecha = new Label();
            gbInfoProveedor = new GroupBox();
            txtNombreProveedor = new TextBox();
            txtNroDoc = new TextBox();
            txtNroDocProveedor = new TextBox();
            lblRazonSocial = new Label();
            lblDoc2 = new Label();
            dgvData = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            txtMontoTotal = new TextBox();
            lblMontoTotal = new Label();
            btnDescargarPdf = new FontAwesome.Sharp.IconButton();
            gboInfoCompra.SuspendLayout();
            gbInfoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(48, 31);
            label1.Name = "label1";
            label1.Size = new Size(773, 753);
            label1.TabIndex = 0;
            // 
            // lblDetalleCompra
            // 
            lblDetalleCompra.AutoSize = true;
            lblDetalleCompra.BackColor = SystemColors.Window;
            lblDetalleCompra.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalleCompra.Location = new Point(65, 49);
            lblDetalleCompra.Name = "lblDetalleCompra";
            lblDetalleCompra.Size = new Size(212, 31);
            lblDetalleCompra.TabIndex = 24;
            lblDetalleCompra.Text = "Detalle de Compra";
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
            btnBuscarS.Location = new Point(376, 105);
            btnBuscarS.Name = "btnBuscarS";
            btnBuscarS.Size = new Size(88, 32);
            btnBuscarS.TabIndex = 29;
            btnBuscarS.Text = "Buscar ";
            btnBuscarS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarS.UseVisualStyleBackColor = false;
            btnBuscarS.UseWaitCursor = true;
            btnBuscarS.Click += btnBuscarDoc_Click;
            // 
            // txtBusquedaDoc
            // 
            txtBusquedaDoc.Location = new Point(213, 107);
            txtBusquedaDoc.Name = "txtBusquedaDoc";
            txtBusquedaDoc.Size = new Size(156, 27);
            txtBusquedaDoc.TabIndex = 37;
            // 
            // lblNroDoc
            // 
            lblNroDoc.AutoSize = true;
            lblNroDoc.Location = new Point(65, 108);
            lblNroDoc.Name = "lblNroDoc";
            lblNroDoc.Size = new Size(152, 20);
            lblNroDoc.TabIndex = 36;
            lblNroDoc.Text = "Número Documento: ";
            // 
            // btnLimpiarForm
            // 
            btnLimpiarForm.BackColor = Color.White;
            btnLimpiarForm.Cursor = Cursors.Hand;
            btnLimpiarForm.FlatAppearance.BorderColor = Color.Black;
            btnLimpiarForm.FlatStyle = FlatStyle.Flat;
            btnLimpiarForm.ForeColor = Color.Black;
            btnLimpiarForm.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiarForm.IconColor = Color.Black;
            btnLimpiarForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarForm.IconSize = 15;
            btnLimpiarForm.Location = new Point(471, 105);
            btnLimpiarForm.Name = "btnLimpiarForm";
            btnLimpiarForm.Size = new Size(88, 32);
            btnLimpiarForm.TabIndex = 38;
            btnLimpiarForm.Text = "Limpiar";
            btnLimpiarForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarForm.UseVisualStyleBackColor = false;
            btnLimpiarForm.Click += btnLimpiarCompra_Click;
            // 
            // gboInfoCompra
            // 
            gboInfoCompra.BackColor = Color.White;
            gboInfoCompra.Controls.Add(txtTipoDocumento);
            gboInfoCompra.Controls.Add(txtUsuario);
            gboInfoCompra.Controls.Add(lblUsuario);
            gboInfoCompra.Controls.Add(txtFecha);
            gboInfoCompra.Controls.Add(lblDoc);
            gboInfoCompra.Controls.Add(lblFecha);
            gboInfoCompra.Location = new Point(65, 157);
            gboInfoCompra.Name = "gboInfoCompra";
            gboInfoCompra.Size = new Size(743, 109);
            gboInfoCompra.TabIndex = 39;
            gboInfoCompra.TabStop = false;
            gboInfoCompra.Text = "Información Compra";
            // 
            // txtTipoDocumento
            // 
            txtTipoDocumento.Location = new Point(182, 60);
            txtTipoDocumento.Name = "txtTipoDocumento";
            txtTipoDocumento.Size = new Size(206, 27);
            txtTipoDocumento.TabIndex = 38;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(395, 60);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 27);
            txtUsuario.TabIndex = 37;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(392, 35);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 36;
            lblUsuario.Text = "Usuario:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(18, 60);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(156, 27);
            txtFecha.TabIndex = 35;
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
            // gbInfoProveedor
            // 
            gbInfoProveedor.BackColor = Color.White;
            gbInfoProveedor.Controls.Add(txtNombreProveedor);
            gbInfoProveedor.Controls.Add(txtNroDoc);
            gbInfoProveedor.Controls.Add(txtNroDocProveedor);
            gbInfoProveedor.Controls.Add(lblRazonSocial);
            gbInfoProveedor.Controls.Add(lblDoc2);
            gbInfoProveedor.Location = new Point(65, 272);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Size = new Size(743, 109);
            gbInfoProveedor.TabIndex = 40;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Información Proveedor";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(182, 60);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(206, 27);
            txtNombreProveedor.TabIndex = 38;
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(395, 60);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(210, 27);
            txtNroDoc.TabIndex = 37;
            // 
            // txtNroDocProveedor
            // 
            txtNroDocProveedor.Location = new Point(18, 60);
            txtNroDocProveedor.Name = "txtNroDocProveedor";
            txtNroDocProveedor.Size = new Size(156, 27);
            txtNroDocProveedor.TabIndex = 35;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(182, 35);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(97, 20);
            lblRazonSocial.TabIndex = 2;
            lblRazonSocial.Text = "Razon Social:";
            // 
            // lblDoc2
            // 
            lblDoc2.AutoSize = true;
            lblDoc2.Location = new Point(15, 33);
            lblDoc2.Name = "lblDoc2";
            lblDoc2.Size = new Size(148, 20);
            lblDoc2.TabIndex = 0;
            lblDoc2.Text = "Número Documento:";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, Subtotal });
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(65, 391);
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
            dgvData.Size = new Size(743, 341);
            dgvData.TabIndex = 41;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 150;
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
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(160, 744);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(156, 27);
            txtMontoTotal.TabIndex = 40;
            txtMontoTotal.Text = "0";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new Point(65, 748);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(97, 20);
            lblMontoTotal.TabIndex = 39;
            lblMontoTotal.Text = "Monto Total: ";
            // 
            // btnDescargarPdf
            // 
            btnDescargarPdf.BackColor = Color.White;
            btnDescargarPdf.Cursor = Cursors.Hand;
            btnDescargarPdf.FlatAppearance.BorderColor = Color.Black;
            btnDescargarPdf.FlatStyle = FlatStyle.Flat;
            btnDescargarPdf.ForeColor = Color.Black;
            btnDescargarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnDescargarPdf.IconColor = Color.Black;
            btnDescargarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDescargarPdf.IconSize = 15;
            btnDescargarPdf.Location = new Point(642, 741);
            btnDescargarPdf.Name = "btnDescargarPdf";
            btnDescargarPdf.Size = new Size(166, 33);
            btnDescargarPdf.TabIndex = 42;
            btnDescargarPdf.Text = "Descargar PDF";
            btnDescargarPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDescargarPdf.UseVisualStyleBackColor = false;
            btnDescargarPdf.Click += btnDescargarPdf_Click;
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 845);
            Controls.Add(btnDescargarPdf);
            Controls.Add(txtMontoTotal);
            Controls.Add(lblMontoTotal);
            Controls.Add(dgvData);
            Controls.Add(gbInfoProveedor);
            Controls.Add(gboInfoCompra);
            Controls.Add(btnLimpiarForm);
            Controls.Add(txtBusquedaDoc);
            Controls.Add(lblNroDoc);
            Controls.Add(btnBuscarS);
            Controls.Add(lblDetalleCompra);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDetalleCompra";
            Text = "frmDetalleCompra";
            Load += frmDetalleCompra_Load;
            gboInfoCompra.ResumeLayout(false);
            gboInfoCompra.PerformLayout();
            gbInfoProveedor.ResumeLayout(false);
            gbInfoProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDetalleCompra;
        private FontAwesome.Sharp.IconButton btnBuscarS;
        private TextBox txtBusquedaDoc;
        private Label lblNroDoc;
        private FontAwesome.Sharp.IconButton btnLimpiarForm;
        private GroupBox gboInfoCompra;
        private TextBox txtTipoDocumento;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtFecha;
        private Label lblDoc;
        private Label lblFecha;
        private GroupBox gbInfoProveedor;
        private TextBox txtNombreProveedor;
        private TextBox txtNroDoc;
        private TextBox txtNroDocProveedor;
        private Label lblRazonSocial;
        private Label lblDoc2;
        private DataGridView dgvData;
        private TextBox txtMontoTotal;
        private Label lblMontoTotal;
        private FontAwesome.Sharp.IconButton btnDescargarPdf;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
    }
}