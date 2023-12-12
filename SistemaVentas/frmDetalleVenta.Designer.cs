namespace CapaPresentacion
{
    partial class frmDetalleVenta
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
            txtMontoTotal = new TextBox();
            dgvData = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            txtNombreProveedor = new TextBox();
            txtNroDoc = new TextBox();
            txtNroDocCliente = new TextBox();
            lblNombreCliente = new Label();
            lblDoc2 = new Label();
            lblMontoTotal = new Label();
            gbInfoProveedor = new GroupBox();
            txtTipoDocumento = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtFecha = new TextBox();
            lblDoc = new Label();
            gbInfo = new GroupBox();
            lblFecha = new Label();
            btnLimpiarForm = new FontAwesome.Sharp.IconButton();
            txtBusquedaDoc = new TextBox();
            lblNroDoc = new Label();
            btnBuscarS = new FontAwesome.Sharp.IconButton();
            lblDetalleVenta = new Label();
            label1 = new Label();
            txtMontoPago = new TextBox();
            lblMontoPago = new Label();
            txtMontoCambio = new TextBox();
            lblMontoCambio = new Label();
            btnDescargarPdf = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            gbInfoProveedor.SuspendLayout();
            gbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(135, 731);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(117, 27);
            txtMontoTotal.TabIndex = 51;
            txtMontoTotal.Text = "0";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, Subtotal });
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(40, 378);
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
            dgvData.TabIndex = 53;
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
            // txtNombreProveedor
            // 
            txtNombreProveedor.Enabled = false;
            txtNombreProveedor.Location = new Point(182, 60);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(403, 27);
            txtNombreProveedor.TabIndex = 38;
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(620, 60);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(107, 27);
            txtNroDoc.TabIndex = 37;
            // 
            // txtNroDocCliente
            // 
            txtNroDocCliente.Enabled = false;
            txtNroDocCliente.Location = new Point(18, 60);
            txtNroDocCliente.Name = "txtNroDocCliente";
            txtNroDocCliente.Size = new Size(156, 27);
            txtNroDocCliente.TabIndex = 35;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(182, 35);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(117, 20);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "Nombre Cliente:";
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
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new Point(40, 735);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(97, 20);
            lblMontoTotal.TabIndex = 49;
            lblMontoTotal.Text = "Monto Total: ";
            // 
            // gbInfoProveedor
            // 
            gbInfoProveedor.BackColor = Color.White;
            gbInfoProveedor.Controls.Add(txtNombreProveedor);
            gbInfoProveedor.Controls.Add(txtNroDoc);
            gbInfoProveedor.Controls.Add(txtNroDocCliente);
            gbInfoProveedor.Controls.Add(lblNombreCliente);
            gbInfoProveedor.Controls.Add(lblDoc2);
            gbInfoProveedor.Location = new Point(40, 259);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Size = new Size(743, 109);
            gbInfoProveedor.TabIndex = 52;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Información Cliente";
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
            txtFecha.Enabled = false;
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
            // gbInfo
            // 
            gbInfo.BackColor = Color.White;
            gbInfo.Controls.Add(txtTipoDocumento);
            gbInfo.Controls.Add(txtUsuario);
            gbInfo.Controls.Add(lblUsuario);
            gbInfo.Controls.Add(txtFecha);
            gbInfo.Controls.Add(lblDoc);
            gbInfo.Controls.Add(lblFecha);
            gbInfo.Location = new Point(40, 144);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(743, 109);
            gbInfo.TabIndex = 50;
            gbInfo.TabStop = false;
            gbInfo.Text = "Información Venta";
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
            btnLimpiarForm.Location = new Point(446, 92);
            btnLimpiarForm.Name = "btnLimpiarForm";
            btnLimpiarForm.Size = new Size(88, 32);
            btnLimpiarForm.TabIndex = 48;
            btnLimpiarForm.Text = "Limpiar";
            btnLimpiarForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarForm.UseVisualStyleBackColor = false;
            btnLimpiarForm.Click += btnLimpiarCompra_Click;
            // 
            // txtBusquedaDoc
            // 
            txtBusquedaDoc.Location = new Point(188, 94);
            txtBusquedaDoc.Name = "txtBusquedaDoc";
            txtBusquedaDoc.Size = new Size(156, 27);
            txtBusquedaDoc.TabIndex = 47;
            // 
            // lblNroDoc
            // 
            lblNroDoc.AutoSize = true;
            lblNroDoc.Location = new Point(40, 95);
            lblNroDoc.Name = "lblNroDoc";
            lblNroDoc.Size = new Size(152, 20);
            lblNroDoc.TabIndex = 46;
            lblNroDoc.Text = "Número Documento: ";
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
            btnBuscarS.Location = new Point(351, 92);
            btnBuscarS.Name = "btnBuscarS";
            btnBuscarS.Size = new Size(88, 32);
            btnBuscarS.TabIndex = 45;
            btnBuscarS.Text = "Buscar ";
            btnBuscarS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarS.UseVisualStyleBackColor = false;
            btnBuscarS.Click += btnBuscarDoc_Click;
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.BackColor = SystemColors.Window;
            lblDetalleVenta.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalleVenta.Location = new Point(40, 36);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(189, 31);
            lblDetalleVenta.TabIndex = 44;
            lblDetalleVenta.Text = "Detalle de Venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(773, 803);
            label1.TabIndex = 43;
            // 
            // txtMontoPago
            // 
            txtMontoPago.Location = new Point(366, 731);
            txtMontoPago.Name = "txtMontoPago";
            txtMontoPago.Size = new Size(117, 27);
            txtMontoPago.TabIndex = 56;
            txtMontoPago.Text = "0";
            // 
            // lblMontoPago
            // 
            lblMontoPago.AutoSize = true;
            lblMontoPago.Location = new Point(271, 735);
            lblMontoPago.Name = "lblMontoPago";
            lblMontoPago.Size = new Size(97, 20);
            lblMontoPago.TabIndex = 55;
            lblMontoPago.Text = "Monto Pago: ";
            // 
            // txtMontoCambio
            // 
            txtMontoCambio.Location = new Point(621, 732);
            txtMontoCambio.Name = "txtMontoCambio";
            txtMontoCambio.Size = new Size(117, 27);
            txtMontoCambio.TabIndex = 58;
            txtMontoCambio.Text = "0";
            // 
            // lblMontoCambio
            // 
            lblMontoCambio.AutoSize = true;
            lblMontoCambio.Location = new Point(499, 735);
            lblMontoCambio.Name = "lblMontoCambio";
            lblMontoCambio.Size = new Size(116, 20);
            lblMontoCambio.TabIndex = 57;
            lblMontoCambio.Text = "Monto Cambio: ";
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
            btnDescargarPdf.Location = new Point(617, 777);
            btnDescargarPdf.Name = "btnDescargarPdf";
            btnDescargarPdf.Size = new Size(166, 33);
            btnDescargarPdf.TabIndex = 59;
            btnDescargarPdf.Text = "Descargar PDF";
            btnDescargarPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDescargarPdf.UseVisualStyleBackColor = false;
            btnDescargarPdf.Click += btnDescargarPdf_Click;
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 856);
            Controls.Add(btnDescargarPdf);
            Controls.Add(txtMontoCambio);
            Controls.Add(lblMontoCambio);
            Controls.Add(txtMontoPago);
            Controls.Add(lblMontoPago);
            Controls.Add(txtMontoTotal);
            Controls.Add(dgvData);
            Controls.Add(lblMontoTotal);
            Controls.Add(gbInfoProveedor);
            Controls.Add(gbInfo);
            Controls.Add(btnLimpiarForm);
            Controls.Add(txtBusquedaDoc);
            Controls.Add(lblNroDoc);
            Controls.Add(btnBuscarS);
            Controls.Add(lblDetalleVenta);
            Controls.Add(label1);
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
            Load += frmDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            gbInfoProveedor.ResumeLayout(false);
            gbInfoProveedor.PerformLayout();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMontoTotal;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private TextBox txtNombreProveedor;
        private TextBox txtNroDoc;
        private TextBox txtNroDocCliente;
        private Label lblNombreCliente;
        private Label lblDoc2;
        private Label lblMontoTotal;
        private GroupBox gbInfoProveedor;
        private TextBox txtTipoDocumento;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtFecha;
        private Label lblDoc;
        private GroupBox gbInfo;
        private Label lblFecha;
        private FontAwesome.Sharp.IconButton btnLimpiarForm;
        private TextBox txtBusquedaDoc;
        private Label lblNroDoc;
        private FontAwesome.Sharp.IconButton btnBuscarS;
        private Label lblDetalleVenta;
        private Label label1;
        private TextBox txtMontoPago;
        private Label lblMontoPago;
        private TextBox txtMontoCambio;
        private Label lblMontoCambio;
        private FontAwesome.Sharp.IconButton btnDescargarPdf;
    }
}