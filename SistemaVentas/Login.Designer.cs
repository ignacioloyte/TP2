namespace CapaPresentacion
{
    partial class Login
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
            label1 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            lbltitulo = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            pictureBox1 = new PictureBox();
            lbltitulo2 = new Label();
            cbIdioma = new ComboBox();
            btnSeleccionarIdioma = new FontAwesome.Sharp.IconButton();
            lblIdioma = new Label();
            btnAyuda = new FontAwesome.Sharp.IconButton();
            btnRegistrarUsuario = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOrange;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 375);
            label1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(218, 135);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(374, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(218, 198);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(374, 27);
            txtClave.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(218, 112);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(218, 175);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkOrange;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnIngresar.IconColor = Color.White;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.IconSize = 25;
            btnIngresar.Location = new Point(291, 244);
            btnIngresar.Margin = new Padding(2, 3, 2, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(107, 37);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.Location = new Point(411, 244);
            btnCancelar.Margin = new Padding(2, 3, 2, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 37);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.DarkOrange;
            lbltitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.Snow;
            lbltitulo.Location = new Point(14, 92);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(153, 25);
            lbltitulo.TabIndex = 9;
            lbltitulo.Text = "Ingreso Sistema";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.DarkOrange;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 63;
            iconPictureBox1.Location = new Point(14, 27);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(66, 63);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ferre_dni_1;
            pictureBox1.Location = new Point(274, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lbltitulo2
            // 
            lbltitulo2.AutoSize = true;
            lbltitulo2.BackColor = Color.DarkOrange;
            lbltitulo2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo2.ForeColor = Color.Snow;
            lbltitulo2.Location = new Point(14, 119);
            lbltitulo2.Name = "lbltitulo2";
            lbltitulo2.Size = new Size(96, 25);
            lbltitulo2.TabIndex = 11;
            lbltitulo2.Text = "de ventas";
            // 
            // cbIdioma
            // 
            cbIdioma.FormattingEnabled = true;
            cbIdioma.Location = new Point(16, 235);
            cbIdioma.Name = "cbIdioma";
            cbIdioma.Size = new Size(151, 28);
            cbIdioma.TabIndex = 12;
            // 
            // btnSeleccionarIdioma
            // 
            btnSeleccionarIdioma.BackColor = Color.DarkOrange;
            btnSeleccionarIdioma.Cursor = Cursors.Hand;
            btnSeleccionarIdioma.FlatStyle = FlatStyle.Flat;
            btnSeleccionarIdioma.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionarIdioma.ForeColor = Color.White;
            btnSeleccionarIdioma.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnSeleccionarIdioma.IconColor = Color.White;
            btnSeleccionarIdioma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeleccionarIdioma.IconSize = 20;
            btnSeleccionarIdioma.Location = new Point(16, 269);
            btnSeleccionarIdioma.Margin = new Padding(2, 3, 2, 3);
            btnSeleccionarIdioma.Name = "btnSeleccionarIdioma";
            btnSeleccionarIdioma.Size = new Size(151, 31);
            btnSeleccionarIdioma.TabIndex = 13;
            btnSeleccionarIdioma.Text = "Seleccionar";
            btnSeleccionarIdioma.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeleccionarIdioma.UseVisualStyleBackColor = false;
            btnSeleccionarIdioma.Click += btnSeleccionarIdioma_Click;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.BackColor = Color.DarkOrange;
            lblIdioma.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdioma.ForeColor = SystemColors.ButtonHighlight;
            lblIdioma.Location = new Point(21, 208);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(56, 20);
            lblIdioma.TabIndex = 14;
            lblIdioma.Text = "Idioma";
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
            btnAyuda.Location = new Point(561, 325);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(52, 38);
            btnAyuda.TabIndex = 15;
            btnAyuda.UseVisualStyleBackColor = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(302, 330);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(94, 29);
            btnRegistrarUsuario.TabIndex = 16;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 128, 0);
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton1.IconColor = Color.Snow;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(561, 13);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(52, 43);
            iconButton1.TabIndex = 17;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(625, 375);
            Controls.Add(iconButton1);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(btnAyuda);
            Controls.Add(lblIdioma);
            Controls.Add(btnSeleccionarIdioma);
            Controls.Add(cbIdioma);
            Controls.Add(lbltitulo2);
            Controls.Add(pictureBox1);
            Controls.Add(lbltitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label lblUsuario;
        private Label lblContraseña;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Label lbltitulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private PictureBox pictureBox1;
        private Label lbltitulo2;
        private ComboBox cbIdioma;
        private FontAwesome.Sharp.IconButton btnSeleccionarIdioma;
        private Label lblIdioma;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private Button btnRegistrarUsuario;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}