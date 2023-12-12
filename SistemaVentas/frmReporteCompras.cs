﻿using CapaNegocio;
using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
using ClosedXML.Excel;
using CapaPresentacion.Idioma;

namespace CapaPresentacion
{
    public partial class frmReporteCompras : Form
    {
        public frmReporteCompras()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CapaPresentacion.Properties.Settings.Default.Idioma);
            lblReporteCompra.Text = Textos.lblReporteCompra;
            lblFechaInicio.Text = Textos.lblFechaInicio;
            lblFechaFin.Text = Textos.lblFechaFin;
            btnBuscarS.Text = Textos.btnBuscarS;
            btnExcel.Text = Textos.btnExcel;
            lblBuscar.Text = Textos.lblBuscar;

        }


        private void frmReporteCompras_Load(object sender, EventArgs e)
        {
            CargarIdioma();

            List<Proveedor> lista = new CN_Proveedor().Listar();
            cbProveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" });
            foreach (Proveedor item in lista)
            {
                cbProveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });

            }

            cbProveedor.DisplayMember = "Texto";
            cbProveedor.ValueMember = "Valor";
            cbProveedor.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                cbBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });

            }

            cbBusqueda.DisplayMember = "Texto";
            cbBusqueda.ValueMember = "Valor";
            cbBusqueda.SelectedIndex = 0;


        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            int idproveedor = Convert.ToInt32(((OpcionCombo)cbProveedor.SelectedItem).Valor.ToString());

            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().Compra(
                dtInicio.Value.ToString("dd/MM/yyyy"),
                dtFechaFin.Value.ToString("dd/MM/yyyy"),
                idproveedor
                );

            dgvData.Rows.Clear();

            foreach (ReporteCompra rc in lista)
            {
                dgvData.Rows.Add(new object[] {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.DocumentoProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                 });
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Chequeamos que tenga filas mi tabla
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                //Accedenis a todas las columas del datagrid
                foreach (DataGridViewColumn columna in dgvData.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }// Carga ok las columnas

                foreach (DataGridViewRow row in dgvData.Rows)
                {// Que solo me exporte las filas visibles
                    if (row.Visible)
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString()
                        });

                }
                //Para guardar el excel
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                //Evento que dispara cada vez que aceptamos en la ventana de dialogo para configurar la ruta
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");// le damos un nombre a la hoja del informa
                        hoja.ColumnsUsed().AdjustToContents(); //Que se ajusten las columnas alcontenido
                        wb.SaveAs(savefile.FileName); // Para que se guarde
                        MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else { row.Visible = false; }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
