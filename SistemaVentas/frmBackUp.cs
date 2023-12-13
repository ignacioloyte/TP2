using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;
using System.Linq.Expressions;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmBackUp : Form
    {

        private void LimpiarTextBoxesEnGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private CN_Backup _businessLayer = new CN_Backup();


        public frmBackUp()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

            var backup = new DatabaseBackup { FilePath = txtrestore.Text };
            _businessLayer.PerformRestore(backup);
            // Mostrar mensaje de éxito o manejar errores
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string backupFileName = txtnombrebackup.Text + ".bak";
            string fullPath = Path.Combine(txtbackup.Text, backupFileName);

            var backup = new DatabaseBackup { FilePath = fullPath };

            string errorMessage;
            bool success = _businessLayer.PerformBackup(backup, out errorMessage);

            if (success)
            {
                MessageBox.Show("Backup realizado con éxito.", "Backup Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBoxesEnGroupBox(gbbackup);
            }
            else
            {
                MessageBox.Show($"Error al realizar el backup: {errorMessage}", "Error de Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtbackup.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var backup = new DatabaseBackup { FilePath = txtrestore.Text };
                _businessLayer.PerformRestore(backup);
                MessageBox.Show("Restauración completada con éxito.", "Restauración Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBoxesEnGroupBox(gbrestore);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la restauración: {ex.Message}", "Error de Restauración", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "SQL Server database backup files|*.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtrestore.Text = openFileDialog1.FileName;
            }
        }
    }
}
