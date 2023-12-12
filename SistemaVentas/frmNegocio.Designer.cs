namespace CapaPresentacion
{
    partial class frmNegocio
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
            lblMantenedor = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtCuit = new TextBox();
            lblCuit = new Label();
            txtNombreNegocio = new TextBox();
            lblNombreNegocio = new Label();
            btnSubir = new FontAwesome.Sharp.IconButton();
            lblLogo = new Label();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblMantenedor
            // 
            lblMantenedor.AutoSize = true;
            lblMantenedor.BackColor = Color.White;
            lblMantenedor.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMantenedor.Location = new Point(65, 31);
            lblMantenedor.Name = "lblMantenedor";
            lblMantenedor.Size = new Size(155, 32);
            lblMantenedor.TabIndex = 34;
            lblMantenedor.Text = "Mantenedor";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.None;
            iconPictureBox1.Cursor = Cursors.Cross;
            iconPictureBox1.ForeColor = Color.DarkOrange;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            iconPictureBox1.IconColor = Color.DarkOrange;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(22, 26);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 33;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(458, 589);
            label1.TabIndex = 32;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnGuardarCambios);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(txtCuit);
            groupBox1.Controls.Add(lblCuit);
            groupBox1.Controls.Add(txtNombreNegocio);
            groupBox1.Controls.Add(lblNombreNegocio);
            groupBox1.Controls.Add(btnSubir);
            groupBox1.Controls.Add(lblLogo);
            groupBox1.Controls.Add(picLogo);
            groupBox1.Location = new Point(22, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 397);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.HardDrive;
            btnGuardarCambios.IconColor = Color.Black;
            btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarCambios.IconSize = 25;
            btnGuardarCambios.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarCambios.Location = new Point(187, 236);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Padding = new Padding(2);
            btnGuardarCambios.Size = new Size(219, 29);
            btnGuardarCambios.TabIndex = 9;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(187, 194);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(219, 27);
            txtDireccion.TabIndex = 8;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(184, 171);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Dirección:";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(187, 134);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(219, 27);
            txtCuit.TabIndex = 6;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(184, 111);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(43, 20);
            lblCuit.TabIndex = 5;
            lblCuit.Text = "CUIT:";
            // 
            // txtNombreNegocio
            // 
            txtNombreNegocio.Location = new Point(187, 73);
            txtNombreNegocio.Name = "txtNombreNegocio";
            txtNombreNegocio.Size = new Size(219, 27);
            txtNombreNegocio.TabIndex = 4;
            // 
            // lblNombreNegocio
            // 
            lblNombreNegocio.AutoSize = true;
            lblNombreNegocio.Location = new Point(184, 50);
            lblNombreNegocio.Name = "lblNombreNegocio";
            lblNombreNegocio.Size = new Size(128, 20);
            lblNombreNegocio.TabIndex = 3;
            lblNombreNegocio.Text = "Nombre Negocio:";
            // 
            // btnSubir
            // 
            btnSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnSubir.IconColor = Color.Black;
            btnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSubir.IconSize = 25;
            btnSubir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubir.Location = new Point(16, 236);
            btnSubir.Name = "btnSubir";
            btnSubir.Padding = new Padding(2);
            btnSubir.Size = new Size(158, 29);
            btnSubir.TabIndex = 2;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(16, 50);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(43, 20);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Logo";
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(16, 73);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(158, 148);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 589);
            Controls.Add(groupBox1);
            Controls.Add(lblMantenedor);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMantenedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnSubir;
        private Label lblLogo;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtCuit;
        private Label lblCuit;
        private TextBox txtNombreNegocio;
        private Label lblNombreNegocio;
    }
}