﻿namespace CapaPresentacion
{
    partial class frmUsuario
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            lblNroDoc = new Label();
            lblEmail = new Label();
            lblContraseña = new Label();
            lblNombreUsuario = new Label();
            txtNroDoc = new TextBox();
            txtNUsuario = new TextBox();
            txtEmail = new TextBox();
            txtClave = new TextBox();
            txtConfClave = new TextBox();
            lblConfContraseña = new Label();
            lblRol = new Label();
            cbRol = new ComboBox();
            cbEstado = new ComboBox();
            lblEstado = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnLimpiarForm = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            FechaAlta = new DataGridViewTextBoxColumn();
            FechaBAja = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            lblTituloUsuario = new Label();
            txtId = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblBuscar = new Label();
            cbBusqueda = new ComboBox();
            txtBusqueda = new TextBox();
            btnBusqueda = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            txtNombreCompleto = new TextBox();
            lblNombreCliente = new Label();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblUsuarios = new Label();
            txtIndice = new TextBox();
            btnAyuda = new FontAwesome.Sharp.IconButton();
            dtInicio = new DateTimePicker();
            lblFechaAlta = new Label();
            lblFechaBaja = new Label();
            txtFechaBaja = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 599);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // lblNroDoc
            // 
            lblNroDoc.AutoSize = true;
            lblNroDoc.BackColor = Color.White;
            lblNroDoc.Location = new Point(16, 130);
            lblNroDoc.Name = "lblNroDoc";
            lblNroDoc.Size = new Size(99, 15);
            lblNroDoc.TabIndex = 1;
            lblNroDoc.Text = "Nro. Documento:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.White;
            lblEmail.Location = new Point(18, 224);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.White;
            lblContraseña.Location = new Point(21, 266);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(70, 15);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.White;
            lblNombreUsuario.Location = new Point(18, 85);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(112, 15);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(17, 148);
            txtNroDoc.Margin = new Padding(3, 2, 3, 2);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(179, 23);
            txtNroDoc.TabIndex = 5;
            // 
            // txtNUsuario
            // 
            txtNUsuario.Location = new Point(18, 103);
            txtNUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNUsuario.Name = "txtNUsuario";
            txtNUsuario.Size = new Size(176, 23);
            txtNUsuario.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(21, 241);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(21, 284);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(176, 23);
            txtClave.TabIndex = 8;
            // 
            // txtConfClave
            // 
            txtConfClave.Location = new Point(23, 328);
            txtConfClave.Margin = new Padding(3, 2, 3, 2);
            txtConfClave.Name = "txtConfClave";
            txtConfClave.PasswordChar = '*';
            txtConfClave.Size = new Size(175, 23);
            txtConfClave.TabIndex = 12;
            // 
            // lblConfContraseña
            // 
            lblConfContraseña.AutoSize = true;
            lblConfContraseña.BackColor = Color.White;
            lblConfContraseña.Location = new Point(23, 310);
            lblConfContraseña.Name = "lblConfContraseña";
            lblConfContraseña.Size = new Size(125, 15);
            lblConfContraseña.TabIndex = 11;
            lblConfContraseña.Text = "Confirmar contraseña:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.White;
            lblRol.Location = new Point(24, 442);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 13;
            lblRol.Text = "Rol:";
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(25, 459);
            cbRol.Margin = new Padding(3, 2, 3, 2);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(172, 23);
            cbRol.TabIndex = 14;
            cbRol.SelectedIndexChanged += cbRol_SelectedIndexChanged;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(27, 504);
            cbEstado.Margin = new Padding(3, 2, 3, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(170, 23);
            cbEstado.TabIndex = 16;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.White;
            lblEstado.Location = new Point(27, 486);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado:";
            lblEstado.Click += label8_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 20;
            btnEliminar.Location = new Point(116, 566);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.Location = new Point(27, 540);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 22);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar/Editar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiarForm
            // 
            btnLimpiarForm.BackColor = SystemColors.Highlight;
            btnLimpiarForm.Cursor = Cursors.Hand;
            btnLimpiarForm.FlatAppearance.BorderColor = Color.Black;
            btnLimpiarForm.FlatStyle = FlatStyle.Flat;
            btnLimpiarForm.ForeColor = Color.White;
            btnLimpiarForm.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarForm.IconColor = Color.White;
            btnLimpiarForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarForm.IconSize = 20;
            btnLimpiarForm.Location = new Point(29, 566);
            btnLimpiarForm.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarForm.Name = "btnLimpiarForm";
            btnLimpiarForm.Size = new Size(82, 22);
            btnLimpiarForm.TabIndex = 19;
            btnLimpiarForm.Text = "Limpiar";
            btnLimpiarForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarForm.UseMnemonic = false;
            btnLimpiarForm.UseVisualStyleBackColor = false;
            btnLimpiarForm.Click += btnLimpiarForm_Click;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, NombreUsuario, Documento, NombreCompleto, Email, Clave, IdRol, FechaAlta, FechaBAja, Rol, EstadoValor, Estado });
            dgvData.Location = new Point(256, 85);
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
            dgvData.Size = new Size(1054, 506);
            dgvData.TabIndex = 20;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellFormatting += dgvData_CellFormatting;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.MinimumWidth = 6;
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // Id
            // 
            Id.HeaderText = "IdUsuario";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // NombreUsuario
            // 
            NombreUsuario.HeaderText = "Nombre Usuario";
            NombreUsuario.MinimumWidth = 6;
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            NombreUsuario.Width = 125;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Clave
            // 
            Clave.HeaderText = "Contraseña";
            Clave.MinimumWidth = 6;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            Clave.Width = 125;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.MinimumWidth = 6;
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            IdRol.Width = 125;
            // 
            // FechaAlta
            // 
            FechaAlta.HeaderText = "Fecha Alta";
            FechaAlta.MinimumWidth = 6;
            FechaAlta.Name = "FechaAlta";
            FechaAlta.ReadOnly = true;
            FechaAlta.Width = 125;
            // 
            // FechaBAja
            // 
            FechaBAja.HeaderText = "FechaBaja";
            FechaBAja.MinimumWidth = 6;
            FechaBAja.Name = "FechaBAja";
            FechaBAja.ReadOnly = true;
            FechaBAja.Width = 125;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 125;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "Estado Valor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // lblTituloUsuario
            // 
            lblTituloUsuario.BackColor = Color.White;
            lblTituloUsuario.BorderStyle = BorderStyle.FixedSingle;
            lblTituloUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloUsuario.Location = new Point(256, 7);
            lblTituloUsuario.Name = "lblTituloUsuario";
            lblTituloUsuario.Padding = new Padding(7, 6, 7, 6);
            lblTituloUsuario.Size = new Size(1055, 76);
            lblTituloUsuario.TabIndex = 21;
            lblTituloUsuario.Text = "Lista Usuario:";
            // 
            // txtId
            // 
            txtId.Location = new Point(160, 62);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(36, 23);
            txtId.TabIndex = 22;
            txtId.Text = "0";
            txtId.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.White;
            lblBuscar.Location = new Point(618, 53);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(66, 15);
            lblBuscar.TabIndex = 23;
            lblBuscar.Text = "Buscar por:";
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(695, 50);
            cbBusqueda.Margin = new Padding(3, 2, 3, 2);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(223, 23);
            cbBusqueda.TabIndex = 24;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(928, 51);
            txtBusqueda.Margin = new Padding(3, 2, 3, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(280, 23);
            txtBusqueda.TabIndex = 25;
            // 
            // btnBusqueda
            // 
            btnBusqueda.BackColor = Color.White;
            btnBusqueda.Cursor = Cursors.Hand;
            btnBusqueda.FlatAppearance.BorderColor = Color.Black;
            btnBusqueda.FlatStyle = FlatStyle.Flat;
            btnBusqueda.ForeColor = Color.White;
            btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBusqueda.IconColor = Color.Black;
            btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBusqueda.IconSize = 27;
            btnBusqueda.Location = new Point(1213, 50);
            btnBusqueda.Margin = new Padding(3, 2, 3, 2);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(43, 22);
            btnBusqueda.TabIndex = 26;
            btnBusqueda.UseVisualStyleBackColor = false;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.Black;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 27;
            btnLimpiar.Location = new Point(1262, 50);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(38, 22);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(19, 194);
            txtNombreCompleto.Margin = new Padding(3, 2, 3, 2);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(176, 23);
            txtNombreCompleto.TabIndex = 29;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.BackColor = Color.White;
            lblNombreCliente.Location = new Point(16, 176);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(108, 15);
            lblNombreCliente.TabIndex = 28;
            lblNombreCliente.Text = "Nombre completo:";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.None;
            iconPictureBox1.Cursor = Cursors.Cross;
            iconPictureBox1.ForeColor = Color.DarkOrange;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconPictureBox1.IconColor = Color.DarkOrange;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(18, 17);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(35, 30);
            iconPictureBox1.TabIndex = 30;
            iconPictureBox1.TabStop = false;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.BackColor = Color.White;
            lblUsuarios.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarios.Location = new Point(56, 21);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(89, 25);
            lblUsuarios.TabIndex = 31;
            lblUsuarios.Text = "Usuarios";
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(116, 62);
            txtIndice.Margin = new Padding(3, 2, 3, 2);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(36, 23);
            txtIndice.TabIndex = 33;
            txtIndice.Text = "-1";
            txtIndice.Visible = false;
            txtIndice.TextChanged += txtIndice_TextChanged;
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
            btnAyuda.Location = new Point(1262, 16);
            btnAyuda.Margin = new Padding(3, 2, 3, 2);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(38, 28);
            btnAyuda.TabIndex = 53;
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // dtInicio
            // 
            dtInicio.CustomFormat = "dd/MM/yyyy";
            dtInicio.Enabled = false;
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(24, 374);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(176, 23);
            dtInicio.TabIndex = 54;
            dtInicio.Value = new DateTime(2023, 12, 12, 8, 45, 38, 0);
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.BackColor = Color.White;
            lblFechaAlta.Location = new Point(24, 356);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(65, 15);
            lblFechaAlta.TabIndex = 55;
            lblFechaAlta.Text = "Fecha Alta:";
            // 
            // lblFechaBaja
            // 
            lblFechaBaja.AutoSize = true;
            lblFechaBaja.BackColor = Color.White;
            lblFechaBaja.Location = new Point(25, 401);
            lblFechaBaja.Name = "lblFechaBaja";
            lblFechaBaja.Size = new Size(66, 15);
            lblFechaBaja.TabIndex = 57;
            lblFechaBaja.Text = "Fecha Baja:";
            // 
            // txtFechaBaja
            // 
            txtFechaBaja.Location = new Point(25, 418);
            txtFechaBaja.Margin = new Padding(3, 2, 3, 2);
            txtFechaBaja.Name = "txtFechaBaja";
            txtFechaBaja.Size = new Size(175, 23);
            txtFechaBaja.TabIndex = 58;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1374, 599);
            Controls.Add(txtFechaBaja);
            Controls.Add(lblFechaBaja);
            Controls.Add(lblFechaAlta);
            Controls.Add(dtInicio);
            Controls.Add(btnAyuda);
            Controls.Add(txtIndice);
            Controls.Add(lblUsuarios);
            Controls.Add(iconPictureBox1);
            Controls.Add(txtNombreCompleto);
            Controls.Add(lblNombreCliente);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBusqueda);
            Controls.Add(txtBusqueda);
            Controls.Add(cbBusqueda);
            Controls.Add(lblBuscar);
            Controls.Add(txtId);
            Controls.Add(lblTituloUsuario);
            Controls.Add(dgvData);
            Controls.Add(btnLimpiarForm);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(cbEstado);
            Controls.Add(lblEstado);
            Controls.Add(cbRol);
            Controls.Add(lblRol);
            Controls.Add(txtConfClave);
            Controls.Add(lblConfContraseña);
            Controls.Add(txtClave);
            Controls.Add(txtEmail);
            Controls.Add(txtNUsuario);
            Controls.Add(txtNroDoc);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblEmail);
            Controls.Add(lblNroDoc);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmUsuario";
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNroDoc;
        private Label lblEmail;
        private Label lblContraseña;
        private Label lblNombreUsuario;
        private TextBox txtNroDoc;
        private TextBox txtNUsuario;
        private TextBox txtEmail;
        private TextBox txtClave;
        private TextBox txtConfClave;
        private Label lblConfContraseña;
        private Label lblRol;
        private ComboBox cbRol;
        private ComboBox cbEstado;
        private Label lblEstado;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiarForm;
        private DataGridView dgvData;
        private Label lblTituloUsuario;
        private TextBox txtId;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblBuscar;
        private ComboBox cbBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private TextBox txtNombreCompleto;
        private Label lblNombreCliente;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblUsuarios;
        private TextBox txtIndice;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private DateTimePicker dtInicio;
        private Label lblFechaAlta;
        private Label lblFechaBaja;
        private TextBox txtFechaBaja;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn FechaAlta;
        private DataGridViewTextBoxColumn FechaBAja;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}