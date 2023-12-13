using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Idioma;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;

namespace CapaPresentacion
{
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();


        }

        private CN_Log Log = new CN_Log();

        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CapaPresentacion.Properties.Settings.Default.Idioma);
            lblRegistrar.Text = Textos.lblRegistrar;
            lblFechaInicio.Text = Textos.lblFechaInicio;
            lblFechaFin.Text = Textos.lblFechaFin;
            btnBuscarS.Text = Textos.btnBuscarS;
            btnExcel.Text = Textos.btnExcel;



        }
        private void LoadLogEntries()
        {
            dgvData.DataSource = Log.GetAllLogEntries();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            CargarIdioma();
            LoadLogEntries();

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FiltrarPorFecha();
        }


        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    Title = "Guardar como Excel"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToExcel(dgvData, saveFileDialog.FileName);
                    MessageBox.Show("Exportado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {

        }
        private void FiltrarPorFecha()
        {
            DateTime fechaInicio = dtInicio.Value.Date;
            DateTime fechaFin = dtFechaFin.Value.Date;

            // Asegúrate de que la fecha de inicio no sea posterior a la fecha de fin
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.");
                return;
            }

            var listaFiltrada = Log.GetAllLogEntries()
     .Where(entry => entry.Timestamp.Date >= fechaInicio && entry.Timestamp.Date <= fechaFin)
     .ToList();

            dgvData.DataSource = new BindingList<LogEntry>(listaFiltrada);



        }

        public static void ExportDataGridViewToExcel(DataGridView dgv, string filePath)
        {
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());

                Sheet sheet = new Sheet()
                {
                    Id = workbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Sheet 1"
                };

                sheets.Append(sheet);

                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Añadimos el Header para el excel
                Row headerRow = new Row();
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    Cell cell = new Cell
                    {
                        DataType = CellValues.String,
                        CellValue = new CellValue(column.HeaderText)
                    };
                    headerRow.AppendChild(cell);
                }
                sheetData.AppendChild(headerRow);

                // Le agregamos el resto de data
                foreach (DataGridViewRow dgvRow in dgv.Rows)
                {
                    Row newRow = new Row();
                    foreach (DataGridViewCell cell in dgvRow.Cells)
                    {
                        newRow.AppendChild(new Cell
                        {
                            DataType = CellValues.String,
                            CellValue = new CellValue(cell.Value?.ToString() ?? "")
                        });
                    }
                    sheetData.AppendChild(newRow);
                }

                workbookPart.Workbook.Save();
            }
        }
    }
}
