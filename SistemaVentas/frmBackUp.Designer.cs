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
            gbbackup = new GroupBox();
            label3 = new Label();
            button3 = new Button();
            txtnombrebackup = new TextBox();
            label2 = new Label();
            button2 = new Button();
            txtbackup = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            button4 = new Button();
            gbrestore = new GroupBox();
            label4 = new Label();
            button5 = new Button();
            txtrestore = new TextBox();
            gbbackup.SuspendLayout();
            gbrestore.SuspendLayout();
            SuspendLayout();
            // 
            // gbbackup
            // 
            gbbackup.BackColor = Color.White;
            gbbackup.Controls.Add(label3);
            gbbackup.Controls.Add(button3);
            gbbackup.Controls.Add(txtnombrebackup);
            gbbackup.Controls.Add(label2);
            gbbackup.Controls.Add(button2);
            gbbackup.Controls.Add(txtbackup);
            gbbackup.Location = new Point(18, 23);
            gbbackup.Margin = new Padding(3, 2, 3, 2);
            gbbackup.Name = "gbbackup";
            gbbackup.Padding = new Padding(3, 2, 3, 2);
            gbbackup.Size = new Size(794, 152);
            gbbackup.TabIndex = 40;
            gbbackup.TabStop = false;
            gbbackup.Text = "Backup";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 92);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 43;
            label3.Text = "Nombre Backup";
            // 
            // button3
            // 
            button3.Location = new Point(653, 126);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(109, 22);
            button3.TabIndex = 46;
            button3.Text = "Crear Backup";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtnombrebackup
            // 
            txtnombrebackup.Location = new Point(120, 89);
            txtnombrebackup.Margin = new Padding(3, 2, 3, 2);
            txtnombrebackup.Name = "txtnombrebackup";
            txtnombrebackup.Size = new Size(642, 23);
            txtnombrebackup.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 59);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 41;
            label2.Text = "Directorio";
            // 
            // button2
            // 
            button2.Location = new Point(679, 57);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 40;
            button2.Text = "Examinar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtbackup
            // 
            txtbackup.Location = new Point(120, 57);
            txtbackup.Margin = new Padding(3, 2, 3, 2);
            txtbackup.Name = "txtbackup";
            txtbackup.Size = new Size(545, 23);
            txtbackup.TabIndex = 38;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            button4.Location = new Point(653, 102);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 47;
            button4.Text = "Restaurar Backup";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // gbrestore
            // 
            gbrestore.BackColor = Color.White;
            gbrestore.Controls.Add(button4);
            gbrestore.Controls.Add(label4);
            gbrestore.Controls.Add(button5);
            gbrestore.Controls.Add(txtrestore);
            gbrestore.Location = new Point(18, 179);
            gbrestore.Margin = new Padding(3, 2, 3, 2);
            gbrestore.Name = "gbrestore";
            gbrestore.Padding = new Padding(3, 2, 3, 2);
            gbrestore.Size = new Size(794, 152);
            gbrestore.TabIndex = 47;
            gbrestore.TabStop = false;
            gbrestore.Text = "Restore";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 58);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 41;
            label4.Text = "Directorio";
            // 
            // button5
            // 
            button5.Location = new Point(679, 57);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 40;
            button5.Text = "Examinar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtrestore
            // 
            txtrestore.Location = new Point(120, 57);
            txtrestore.Margin = new Padding(3, 2, 3, 2);
            txtrestore.Name = "txtrestore";
            txtrestore.Size = new Size(545, 23);
            txtrestore.TabIndex = 38;
            // 
            // frmBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 399);
            Controls.Add(gbrestore);
            Controls.Add(gbbackup);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBackUp";
            Text = "frmBackUp";
            gbbackup.ResumeLayout(false);
            gbbackup.PerformLayout();
            gbrestore.ResumeLayout(false);
            gbrestore.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbbackup;
        private Label label2;
        private Button button2;
        private TextBox txtbackup;
        private Label label3;
        private TextBox txtnombrebackup;
        private Button button3;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        private GroupBox gbrestore;
        private Label label4;
        private Button button5;
        private TextBox txtrestore;
    }
}