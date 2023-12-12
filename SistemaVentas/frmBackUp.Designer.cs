namespace CapaPresentacion
{
    partial class frmBackUp
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
            gboInfoCompra = new GroupBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            txtFecha = new TextBox();
            lblFecha = new Label();
            button3 = new Button();
            button4 = new Button();
            gboInfoCompra.SuspendLayout();
            SuspendLayout();
            // 
            // gboInfoCompra
            // 
            gboInfoCompra.BackColor = Color.White;
            gboInfoCompra.Controls.Add(label4);
            gboInfoCompra.Controls.Add(textBox3);
            gboInfoCompra.Controls.Add(label3);
            gboInfoCompra.Controls.Add(textBox2);
            gboInfoCompra.Controls.Add(label2);
            gboInfoCompra.Controls.Add(button2);
            gboInfoCompra.Controls.Add(comboBox1);
            gboInfoCompra.Controls.Add(textBox1);
            gboInfoCompra.Controls.Add(label1);
            gboInfoCompra.Controls.Add(button1);
            gboInfoCompra.Controls.Add(txtFecha);
            gboInfoCompra.Controls.Add(lblFecha);
            gboInfoCompra.Location = new Point(21, 31);
            gboInfoCompra.Name = "gboInfoCompra";
            gboInfoCompra.Size = new Size(907, 325);
            gboInfoCompra.TabIndex = 40;
            gboInfoCompra.TabStop = false;
            gboInfoCompra.Text = "Información Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 164);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 45;
            label4.Text = "Nombre Backup";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(137, 161);
            textBox3.MaxLength = 100;
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(733, 121);
            textBox3.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 122);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 43;
            label3.Text = "Nombre Backup";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(733, 27);
            textBox2.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 79);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 41;
            label2.Text = "Directorio";
            // 
            // button2
            // 
            button2.Location = new Point(776, 76);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 40;
            button2.Text = "Examinar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(599, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 28);
            comboBox1.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(622, 27);
            textBox1.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 35);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 37;
            label1.Text = "Bds";
            // 
            // button1
            // 
            button1.Location = new Point(449, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 36;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(137, 32);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(306, 27);
            txtFecha.TabIndex = 35;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(15, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(103, 20);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Servidor Local";
            // 
            // button3
            // 
            button3.Location = new Point(298, 373);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 46;
            button3.Text = "Crear Backup";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(439, 373);
            button4.Name = "button4";
            button4.Size = new Size(125, 29);
            button4.TabIndex = 47;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            // 
            // frmBackUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 431);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(gboInfoCompra);
            Name = "frmBackUp";
            Text = "frmBackUp";
            gboInfoCompra.ResumeLayout(false);
            gboInfoCompra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboInfoCompra;
        private Label label2;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox txtFecha;
        private Label lblFecha;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
    }
}